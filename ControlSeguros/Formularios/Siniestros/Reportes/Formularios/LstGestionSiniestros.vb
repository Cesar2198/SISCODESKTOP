Imports Utilerias.Genericas

Public Class LstGestionSiniestros

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub LstGestionSiniestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFecha.Valor = Date.Today
        Me.cboEjecutivoCta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboEjecutivoCta.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Gestion Siniestros " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaSiniestros.ExportToXls(Archivo, Opciones)

            'PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "")
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

    End Sub

    Private Sub AgregarGestiónDeSiniestrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarGestiónDeSiniestrosToolStripMenuItem.Click
        ''lo que haremos es ingresar una nueva gestión con la factura selecionada
        Try
            Dim fila As Integer = Me.VistaSiniestros.FocusedRowHandle
            If fila >= 0 Then
                Dim frmGestion As New Gestiones
                frmGestion.TipoGestion = "S"
                frmGestion.IdCliente = ""
                frmGestion.IdPoliza = Me.VistaSiniestros.GetRowCellValue(fila, "IdPoliza")
                frmGestion.IdProducto = Me.VistaSiniestros.GetRowCellValue(fila, "IdProducto")
                frmGestion.IdSiniestro = Me.VistaSiniestros.GetRowCellValue(fila, "IdSiniestro")
                frmGestion.IdCertificado = Me.VistaSiniestros.GetRowCellValue(fila, "IdCertificado")
                frmGestion.NumeroFactura = ""
                frmGestion.dbTabla = "Gestiones"
                frmGestion.STIConn = StiGlobalConn
                frmGestion.Permiso = Me.Permiso

                frmGestion.ShowDialog()

                'ahora lo que haremos es actualizar el estatus de gestion de la fila afectada (colores)
                Dim Pen As Integer = 0, Tra As Integer = 0
                Try
                    Pen = StiGlobalConn.ObtenerDataset("select count(*) from gestiones as g where g.IdProducto = " & dbStr(Me.VistaSiniestros.GetRowCellValue(fila, "IdProducto")) & " and g.IdSiniestro = " & dbStr(Me.VistaSiniestros.GetRowCellValue(fila, "IdSiniestro")) & " and g.IdPoliza = " & dbStr(Me.VistaSiniestros.GetRowCellValue(fila, "IdPoliza")) & " and g.TipoGestion = 'S' and g.FechaProximaGestion <= " & dbFec(Date.Today)).Tables(0).Rows(0).Item(0)
                    Tra = StiGlobalConn.ObtenerDataset("select count(*) from gestiones as g where g.IdProducto = " & dbStr(Me.VistaSiniestros.GetRowCellValue(fila, "IdProducto")) & " and g.IdSiniestro = " & dbStr(Me.VistaSiniestros.GetRowCellValue(fila, "IdSiniestro")) & " and g.IdPoliza = " & dbStr(Me.VistaSiniestros.GetRowCellValue(fila, "IdPoliza")) & " and g.TipoGestion = 'S' and g.FechaProximaGestion > " & dbFec(Date.Today)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    Pen = 0
                    Tra = 0
                End Try
                Me.VistaSiniestros.SetRowCellValue(fila, "GestionPendiente", Pen)
                Me.VistaSiniestros.SetRowCellValue(fila, "GestionTramite", Tra)

            Else
                MsgBox("Debe seleccionar el siniestro al que desea ingresarle una gestión.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CosultarGestionesClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CosultarGestionesClienteToolStripMenuItem.Click
        Try
            Dim fila As Integer = Me.VistaSiniestros.FocusedRowHandle
            If fila >= 0 Then
                Dim IdGestion As Integer = -1
                Try
                    IdGestion = StiGlobalConn.ObtenerDataset("select idgestion from gestiones where IdPoliza = " & dbStr(Me.VistaSiniestros.GetRowCellValue(fila, "IdPoliza")) & " and IdProducto = " & dbStr(Me.VistaSiniestros.GetRowCellValue(fila, "IdProducto")) & " and IdSiniestro = " & dbStr(Me.VistaSiniestros.GetRowCellValue(fila, "IdSiniestro")) & " order by FechaProximaGestion desc").Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    IdGestion = -1
                End Try

                If IdGestion <> -1 Then
                    Dim frmGestion As New Gestiones
                    frmGestion.TipoGestion = "S"
                    frmGestion.IdCliente = ""
                    frmGestion.IdPoliza = Me.VistaSiniestros.GetRowCellValue(fila, "IdPoliza")
                    frmGestion.IdProducto = Me.VistaSiniestros.GetRowCellValue(fila, "IdProducto")
                    frmGestion.IdSiniestro = Me.VistaSiniestros.GetRowCellValue(fila, "IdSiniestro")
                    frmGestion.IdCertificado = Me.VistaSiniestros.GetRowCellValue(fila, "IdCertificado")
                    frmGestion.NumeroFactura = ""
                    frmGestion.dbTabla = "Gestiones"
                    frmGestion.STIConn = StiGlobalConn
                    frmGestion.Permiso = Me.Permiso
                    frmGestion.dbCondicion = "IdGestion=" & dbInt(IdGestion)
                    frmGestion.ShowDialog()
                Else
                    MsgBox("El Reclamo seleccionado no tiene gestión realizada.", MsgBoxStyle.Information, "AVISO...")
                End If
            Else
                MsgBox("Debe seleccionar el reclamo al que desea ingresarle una gestión.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            ''buscaremos los reclamos pendientes a la fecha de corte
            If Me.txtFecha.Text = "" Then
                MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim sql As String = ""

            sql = "  select "
            sql &= " a.Nombre as Aseguradora"
            sql &= " , s.IdPoliza"
            sql &= " , p.Descripcion as Producto"
            sql &= " , s.IdProducto"
            sql &= " , s.IdCertificado"
            sql &= " , s.IdSiniestro"
            sql &= " , s.FechaOcurrido as FechaIncurrido"
            sql &= " , s.FechaPresentado "
            sql &= " , case "
            sql &= " when DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") > 150 then '6) Más de 150'"
            sql &= " when DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") <= 30 then '1) de 0 - 30 días'"
            sql &= " when DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") > 30 and DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") <= 60 then '2) de 30 - 60 días'"
            sql &= " when DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") > 60 and DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") <= 90 then '3) de 60 - 90 días'"
            sql &= " when DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") > 90 and DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") <= 120 then '4) de 90 - 120 días'"
            sql &= " when DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") > 120 and DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") <= 150 then '5) de 120 - 150 días'"
            sql &= " end as Rango"
            sql &= " , DateDiff(d,s.FechaPresentado," & dbFec(txtFecha.Valor) & ") as Dias"
            sql &= " , s.TotalPresentado"
            sql &= " , s.TotalPendiente"
            sql &= " , s.TotalReembolso"
            sql &= " , (select count(*) from gestiones as g where g.IdProducto = s.IdProducto and g.IdSiniestro = s.IdSiniestro and g.IdPoliza = s.IdPoliza and g.TipoGestion = 'S' and g.FechaProximaGestion <= " & dbFec(Date.Today) & ") as GestionPendiente"
            sql &= " , (select count(*) from gestiones as g where g.IdProducto = s.IdProducto and g.IdSiniestro = s.IdSiniestro and g.IdPoliza = s.IdPoliza and g.TipoGestion = 'S' and g.FechaProximaGestion > " & dbFec(Date.Today) & ") as GestionTramite"
            sql &= " , s.NombrePresentaReclamo as Asegurado"
            sql &= ", isnull(cp.GrupoCliente,'') as GrupoCliente"
            sql &= ", isnull((select top 1 NombreUsuario from usuarios where idusuario = s.usuariograbacion),'') as UsuarioGraba"
            sql &= ", s.IdSiniestroAseguradora"
            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on p.idproducto = s.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " inner join Polizas as po on po.idpoliza = s.idpoliza and po.idproducto = s.idproducto"
            sql &= " inner join PolizasCertificados as c on c.idpoliza = s.idpoliza and c.idproducto = s.idproducto and c.idcertificado = s.idcertificado"
            sql &= " left join Clientes as cp on cp.idcliente = po.idcliente "
            sql &= " left join Clientes as cc on cc.idcliente = c.idcliente"
            sql &= " where s.EstadoSiniestro in ('DECLARADO','PENDIENTE')"
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = s.idpoliza and pol.idproducto = s.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            If cboEjecutivoCta.Text <> "" Then
                sql &= " and (cp.EjecutivoCta = " & dbStr(Me.cboEjecutivoCta.Valor) & " or cc.EjecutivoCta = " & dbStr(Me.cboEjecutivoCta.Valor) & ") "
            End If

            Dim dsDatos As DataSet = StiGlobalConn.ObtenerDataset(sql)
            GridSiniestros.DataSource = dsDatos.Tables(0)
            GridSiniestros.Refresh()

            If dsDatos.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron siniestros pendientes para la fecha de corte especificada.", MsgBoxStyle.Information, "AVISO..")
                lblLog.Text = ""
            Else
                lblLog.Text = "Núm. Reclamos: " & Format(dsDatos.Tables(0).Rows.Count, "#,###0")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub VistaSiniestros_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaSiniestros.DoubleClick
        Try
            Dim FRec As Integer = VistaSiniestros.FocusedRowHandle
            If FRec >= 0 Then
                Dim Poliza As String = Me.VistaSiniestros.GetRowCellValue(FRec, "IdPoliza")
                Dim Producto As String = Me.VistaSiniestros.GetRowCellValue(FRec, "IdProducto")
                Dim Certificado As String = Me.VistaSiniestros.GetRowCellValue(FRec, "IdCertificado")
                Dim Reclamo As String = Me.VistaSiniestros.GetRowCellValue(FRec, "IdSiniestro")


                Dim POL As New SiniestrosMan
                POL.Permiso = Me.Permiso
                POL.STIConn = StiGlobalConn
                POL.dbTabla = "Siniestros"
                POL.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto) & " and IdCertificado = " & dbStr(Certificado) & " and IdSiniestro = " & dbStr(Reclamo)
                POL.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
