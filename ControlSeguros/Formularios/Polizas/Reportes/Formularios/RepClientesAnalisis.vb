Imports Utilerias.Genericas

Public Class RepClientesAnalisis

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Clientes" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridClientes.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Clientes", "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "", clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CargarDatos()
        Try
            Dim sql As String = ""
            Dim ClaveCliente As String = clSeguros.ObtenerDBParametros("Cliente.CmpEsp")

            sql = "   select "
            sql &= "  c.IdCliente"
            sql &= ", c.NombreCliente"
            sql &= ", c.Dui"
            sql &= ", c.RegistroFiscal"
            sql &= ", c.Giro"
            sql &= ", c.FechaNacimiento"
            sql &= ", c.Email"
            sql &= ", c.Fax"
            sql &= ", c.IdTipoCliente"
            'sql &= ", c.EjecutivoCta"
            sql &= ", c.LugarTrabajo"
            sql &= ", d.Telefono"
            sql &= ", d.Direccion"
            sql &= ", d.Ciudad"
            sql &= ", d.Cargo"
            sql &= ", p.IdPoliza"
            sql &= ", a.Nombre as Aseguradora"
            sql &= ", pr.Descripcion as Producto"
            sql &= ", r.NombreRamo as Ramo"
            sql &= ", c.FechaVinculacion, c.NombreRepLegal, c.FnacRepLegal"
            sql &= ", isnull(c.GrupoCliente,'') as GrupoCliente"
            If ClaveCliente.Trim.ToUpper = "CPCNCJ" Then
                sql &= ", nat_NombreCliente, nat_DireccionCasa, "
                sql &= "nat_TelCasa, nat_TelMovil, nat_EstadoCivil, nat_TieneHijos, nat_NumHijos, nat_EmailCasa, nat_PinBB, nat_Facebook, nat_twitter, nat_Profesion, nat_LugarTrabajo, "
                sql &= "nat_Cargo, nat_DireccionTrabajo, nat_TelTrabajo, nat_FaxTrabajo, nat_EmailTrabajo, nat_PaginaWeb, nat_PreferenciaCobro, nat_ContactoCobro, "
                sql &= "nat_PreferenciaPago, nat_ClienteExistente, nat_ReferidoPor, nat_Hobbie, nat_Deporte, nat_Religion, nat_Comida, nat_Musica, nat_Bebida, nat_MedioInformacion, "
                sql &= "nat_Cesion, nat_CompletaFormulario, nat_FechaFormulario, nat_Comentarios"
                sql &= ",jur_NombreEmpresa, jur_Giro, jur_RepresentanteLegal, jur_PinBB, jur_TelMovil, "
                sql &= "jur_Profesion, jur_EncargadoPoliza, jur_DireccionOficina, jur_TelOficina, jur_FaxOficina, jur_Email, jur_PolPinBB, jur_PaginaWeb, jur_Facebook, jur_Twitter, "
                sql &= "jur_ContactoCobro, jur_CobroTelefono, jur_CobroFax, jur_CobroEmail, jur_ClienteExiste, jur_ReferidoPor, jur_FormaPago, jur_Pagador, jur_Cesion, jur_ActDireccion, "
                sql &= "jur_ActTelefonos, jur_ActFax, jur_ActEmail, jur_ActPaginaWeb, jur_Comentario"
            End If
            sql &= ", isnull((select sum(cer.PrimaNeta) from PolizasCertificados as cer where cer.IdPoliza = p.Idpoliza and cer.IdProducto = p.IdProducto and cer.FechaExclusion is null and cer.RazonExclusion is null ),0) as PrimaNeta"
            sql &= ", (select isnull(NombreVendedor,'') from PolizasVendedores inner join Vendedores on PolizasVendedores.IdVendedor = Vendedores.IdVendedor where PolizasVendedores.IdProducto = p.IdProducto And PolizasVendedores.IdPoliza = p.IdPoliza and PolizasVendedores.Orden = 1) as Vendedor"
            sql &= ", isnull((select usuarios.nombreusuario + ', ' from usuarios inner join ClientesEjecutivos on usuarios.idusuario = ClientesEjecutivos.IdEjecutivo where ClientesEjecutivos.IdCliente = p.idcliente order by ClientesEjecutivos.orden for xml path('')),c.EjecutivoCta) as EjecutivoCta"


            sql &= " from Clientes as c"
            If Me.chkVigentes.Checked = True Then
                sql &= " inner join Polizas as p on p.idcliente = c.idcliente and p.estadopoliza = 'VIGENTE' and p.FechaCancelacion is null "
            Else
                sql &= " left join Polizas as p on p.idcliente = c.idcliente and p.estadopoliza = 'VIGENTE' and p.FechaCancelacion is null "
            End If
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If

            sql &= " left join ClientesContactos as d on d.idcliente = c.idcliente and d.idcontacto = 1"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            
            Dim dtCliente As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            GridClientes.DataSource = dtCliente
            GridClientes.Refresh()
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub RepClientesAnalisis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call AgregarCamposExtra()
        Call CargarDatos()
    End Sub

    Private Sub AgregarCamposExtra()
        Dim ClaveCliente As String = clSeguros.ObtenerDBParametros("Cliente.CmpEsp")
        If ClaveCliente.Trim.ToUpper = "CPCNCJ" Then
            Dim Campos As String = "", Campo As String
            Campos &= "nat_NombreCliente, nat_DireccionCasa, nat_TelCasa, nat_TelMovil, nat_EstadoCivil, nat_TieneHijos, nat_NumHijos, nat_EmailCasa, nat_PinBB, nat_Facebook, nat_twitter, nat_Profesion, nat_LugarTrabajo, "
            Campos &= "nat_Cargo, nat_DireccionTrabajo, nat_TelTrabajo, nat_FaxTrabajo, nat_EmailTrabajo, nat_PaginaWeb, nat_PreferenciaCobro, nat_ContactoCobro, "
            Campos &= "nat_PreferenciaPago, nat_ClienteExistente, nat_ReferidoPor, nat_Hobbie, nat_Deporte, nat_Religion, nat_Comida, nat_Musica, nat_Bebida, nat_MedioInformacion, "
            Campos &= "nat_Cesion, nat_CompletaFormulario, nat_FechaFormulario, nat_Comentarios"
            Campos &= ",jur_NombreEmpresa, jur_Giro, jur_RepresentanteLegal, jur_PinBB, jur_TelMovil, "
            Campos &= "jur_Profesion, jur_EncargadoPoliza, jur_DireccionOficina, jur_TelOficina, jur_FaxOficina, jur_Email, jur_PolPinBB, jur_PaginaWeb, jur_Facebook, jur_Twitter, "
            Campos &= "jur_ContactoCobro, jur_CobroTelefono, jur_CobroFax, jur_CobroEmail, jur_ClienteExiste, jur_ReferidoPor, jur_FormaPago, jur_Pagador, jur_Cesion, jur_ActDireccion, "
            Campos &= "jur_ActTelefonos, jur_ActFax, jur_ActEmail, jur_ActPaginaWeb, jur_Comentario"
            Dim NumCampos As Integer = CuentaCar(Campos, ",")
            For I As Integer = 0 To NumCampos
                Campo = stiSplit(Campos, "G" & I & ",1").Trim
                If Campos <> "" Then
                    Me.GridClientes.Fields.Add(Campo, DevExpress.XtraPivotGrid.PivotArea.FilterArea)
                End If
            Next
        End If
    End Sub

    Dim PosX As Integer, PosY As Integer

    Private Sub GridClientes_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles GridClientes.CustomSummary
        Dim name As String = e.DataField.FieldName

        If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
            Dim list As IList = e.CreateDrillDownDataSource()
            Dim ht As Hashtable = New Hashtable
            For i As Integer = 0 To list.Count - 1
                Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)
                Dim v As Object = row(name)
                If Not IsNothing(v) AndAlso (Not v Is DBNull.Value) Then
                    ht(v) = v
                End If
            Next
            e.CustomValue = ht.Count
        End If
    End Sub

    Private Sub GridClientes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridClientes.MouseMove
         PosX = e.X : PosY = e.Y
    End Sub

    Private Sub GridClientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridClientes.DoubleClick
        try
            Dim ID As String = "", Codregistro As Integer = 0
            Dim info As DevExpress.XtraPivotGrid.PivotGridHitInfo = GridClientes.CalcHitInfo(New Point(PosX, PosY))

            If Not info Is Nothing Then
                'primero intentamos como un campo data
                Try
                    Select Case info.CellInfo.DataField.FieldName
                        Case "IdCliente"
                            ID = CStr(info.CellInfo.Value).Trim
                    End Select
                Catch ex As Exception
                    ID = ""
                End Try
                'sino intentamo como campo agrupado
                If ID = "" Then
                    Try
                        Select Case info.ValueInfo.Field.FieldName
                            Case "IdCliente"
                                ID = CStr(info.ValueInfo.Value).Trim
                        End Select
                    Catch ex As Exception
                        ID = ""
                    End Try
                End If
                If ID <> "" Then
                    'lanzamos el editor de clientes
                    Dim Frm As New ClientesMan
                    Frm.STIConn = StiGlobalConn
                    Frm.Permiso = "T"
                    Frm.dbTabla = "Clientes"
                    Frm.dbCondicion = "IdCliente = " & dbStr(ID)
                    Frm.ShowDialog()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkVigentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged
        Call CargarDatos()
    End Sub

End Class
