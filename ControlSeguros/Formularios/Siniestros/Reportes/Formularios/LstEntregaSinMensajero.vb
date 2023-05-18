Imports Utilerias.Genericas

Public Class LstEntregaSinMensajero

    Private WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

    Private Sub LstMarcarCorrSalida_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        Me.Filtro = " i.codimpresion in ('VA') and i.descripcion like '%reclamo%' and i.tipoflujo = 'SALIDA' and i.FechaDocMarcadoEntregado is null and i.usuarioimprime = " & dbStr(StiGlobalConn.User)
    End Sub

    Private Sub LstMarcarCorrSalida_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros
        'programaremos el format style condition

        Try
            Me.VistaNav.Columns("FechaImpresion").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.VistaNav.Columns("FechaImpresion").DisplayFormat.FormatString = "dd/MMM/yyyy hh:mm:ss tt"

            Me.VistaNav.Columns("Incluir").OptionsColumn.AllowEdit = True
            Me.VistaNav.Columns("Incluir").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.VistaNav.Columns("Incluir").OptionsFilter.AllowAutoFilter = False

            Me.GridNav.RepositoryItems.Clear()
            RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GridNav.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
            Me.RepositoryItemCheckEdit1.AutoHeight = False
            Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
            CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.VistaNav.OptionsBehavior.Editable = True
            Me.VistaNav.Columns("Incluir").ColumnEdit = Me.RepositoryItemCheckEdit1
            For I As Integer = 0 To Me.VistaNav.Columns.Count - 1
                Select Case VistaNav.Columns(I).FieldName
                    Case "Incluir"
                        VistaNav.Columns(I).OptionsColumn.AllowEdit = True
                    Case Else
                        VistaNav.Columns(I).OptionsColumn.AllowEdit = False
                End Select
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LstMarcarCorrSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GridNav.Height = Me.GridNav.Height - 40
    End Sub

    Public Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Dim NumDocMarcados As Integer = 0
        Dim IdFlujo As String = "", IdImpresion As String = ""
        For NF As Integer = 0 To Me.VistaNav.DataRowCount - 1
            If Me.VistaNav.GetRowCellValue(NF, "Incluir") = True Then
                NumDocMarcados += 1
            End If
        Next
        If NumDocMarcados = 0 Then
            MsgBox("No se han seleccionado documentos.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim NumEntrega As String = clSeguros.ObtenerID("Entrega.Sin.Msg." & StiGlobalConn.User)
        For NF As Integer = 0 To Me.VistaNav.DataRowCount - 1
            If Me.VistaNav.GetRowCellValue(NF, "Incluir") = True Then
                IdFlujo = Me.VistaNav.GetRowCellValue(NF, "IdFlujoDoc")
                IdImpresion = Me.VistaNav.GetRowCellValue(NF, "IdImpresion")
                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set NumEntrega = " & dbStr(NumEntrega) & ", FechaDocMarcadoEntregado = " & dbFec(Date.Now, "1") & " where IdFlujoDoc = " & dbStr(IdFlujo) & " and IdImpresion = " & dbStr(IdImpresion))
            End If
        Next

        'generamos la impresion de los documentos marcados en el día.
        Call ImprimirDocumentoMarcados(Date.Today, NumEntrega)
        Me.CargarRegistros()
    End Sub

    Private Sub ImprimirDocumentoMarcados(ByVal Fecha As Date, ByVal NumEntrega As String)
        Try
            Dim Reporte As New repCRCorrespondenciaMarcadaSiniestro
            Dim sql As String = ""

            sql = "  select "
            sql &= " '' as IdUsuarioEntrega "
            sql &= " , i.IdImpresion, IdFlujoDoc "
            sql &= " , (select d.iddocumento + ' - ' + d.nombredocumento from DocumentosCorrespondencia as d where d.iddocumento = i.codimpresion) as TipoDocumento"
            sql &= " , i.FechaEnDocumento as FechaEnvio"
            sql &= " , i.FechaImpresion as FechaImpresion"
            'sql &= " , i.Descripcion as Comentario"
            sql &= " , isnull(i.idorigen, (select d.NombreCliente from FlujosDocumentos as d where d.idflujodoc =i.idflujodoc )) as IdUsuarioSolicita"
            sql &= " , isnull(i.nombredestinatario,(select d.NombreCliente from FlujosDocumentos as d where d.idflujodoc =i.idflujodoc )) as IdDestinatario"
            sql &= " , u.NombreUsuario as IdUsuarioImprime"
            sql &= " ,s.IdSiniestro as Ciudad"
            sql &= " ,s.FechaOcurrido as FechaInicia"
            sql &= " ,s.DescripcionSiniestro as Comentario"
            sql &= " ,(select top 1 t.descripcionbien from PolizasBienes as t where t.nombrebien = 'PLACA' and t.idpoliza = s.idpoliza and t.idproducto = s.idproducto and t.idcertificado = s.idcertificado) as Zona"
            sql &= " From FlujosDocumentosImpresiones as i"
            sql &= " inner join EnviosSiniestrosDetalle as e on e.idenvio = i.claves"
            sql &= " inner join Siniestros as s on s.idpoliza = e.idpoliza and s.idproducto = e.idproducto and s.idcertificado = e.idcertificado and s.idsiniestro = e.idsiniestro"
            sql &= " left join Usuarios as u on u.idusuario = i.usuarioimprime"
            sql &= " where cast(convert(char(8),i.FechaDocMarcadoEntregado,112) as datetime) = " & dbFec(Fecha)
            sql &= " and i.tipoflujo = 'SALIDA' and i.usuarioimprime = " & dbStr(StiGlobalConn.User)
            If NumEntrega <> "" Then
                sql &= " and i.NumEntrega = " & dbStr(NumEntrega)
            End If


            Dim dtFlujos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFlujos.TableName = "Correspondencia"

            If dtFlujos.Rows.Count = 0 Then
                MsgBox("No se encontró mensajería.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtFlujos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NombreUsuarioRecepcion", clSeguros.ObtenerDBParametros("Nombre.Usuario.Recepcion"))
            SetRepFormulaString(Reporte, "Titulo1", "Control de Entrega de Reclamos")
            SetRepFormulaString(Reporte, "UserLog", "Fecha de Impresión: " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss"))
            If NumEntrega <> "" Then SetRepFormulaString(Reporte, "NumEntrega", "Entrega No.: " & NumEntrega)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()


        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub btnImprimirDocMarcados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDocMarcados.Click
        Call ImprimirDocumentoMarcados(Date.Today, "")
    End Sub

End Class
