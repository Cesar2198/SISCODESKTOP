
Imports Utilerias.Genericas

Public Class SiniestroActClase

    Private Sub SiniestroActClase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboClaseSiniestro.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboClaseSiniestro.Lista = GenerarListaCombo(clSeguros.ObtenerDBParametros("Siniestros.Clases"))
        cboClaseSiniestro.Llenar_Combo()
        cboClaseSiniestro.OcultarColumna(0)

        Call CargarReclamos()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CargarReclamos()

        Dim sql As String = ""
        sql &= " select "
        sql &= "  r.NombreRamo as Ramo"
        sql &= " ,a.Nombre as Aseguradora"
        sql &= " ,p.NombreCliente as Contratante"
        sql &= " ,s.NombrePresentaReclamo as Asegurado"
        sql &= " ,s.IdCertificado as Certificado"
        sql &= " ,c.NombreCliente as TitularCertificado"
        sql &= " ,s.IdPoliza as IdPoliza"
        sql &= " ,s.IdSiniestro as IdSiniestro"
        sql &= " ,s.IdSiniestroAseguradora as IdSiniestroAseguradora"
        sql &= " ,s.FechaPresentado as FechaPresenta"
        sql &= " ,s.FechaOcurrido as FechaOcurre"
        sql &= " ,s.EstadoSiniestro as Estado"
        sql &= " ,s.EstadoSiniestroInterno as EstadoInterno"
        sql &= " ,s.NoFolioReferencia as Referencia"
        sql &= " ,s.DescripcionSiniestro as Descripcion"
        sql &= " ,s.ClaseSiniestro as IdClaseSiniestro"
        sql &= " ,s.IdProducto"
        sql &= " ,cast(0 as bit) as Incluir"
        sql &= " from Siniestros as s "
        sql &= " inner join Productos as d on d.idproducto = s.idproducto "
        sql &= " inner join Aseguradoras as a on a.idaseguradora = d.idaseguradora"
        sql &= " inner join RamoSeguros as r on r.IdRamo = d.IdRamo"
        sql &= " inner join Polizas as p on p.idpoliza = s.idpoliza and p.idproducto = s.idproducto"
        sql &= " inner join PolizasCertificados as c on c.IdPoliza = s.IdPoliza and c.IdProducto = s.IdProducto and c.IdCertificado = s.IdCertificado"
        sql &= " where s.IdSiniestro is not null"

        If optAnioAct.Checked = True Then
            sql &= " and year(s.fechapresentado) = year(getdate())"
            If VisibilidadUsuario() = "D" Then
                sql &= "  and (select count(*) from polizas as p1 where p1.idpoliza = s.idpoliza and p1.idproducto = s.idproducto and p1.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
        End If

        If optAnioAnt.Checked = True Then
            sql &= "  and year(s.fechapresentado) = (year(getdate()) -1 )"
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p1 where p1.idpoliza = s.idpoliza and p1.idproducto = s.idproducto and p1.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
        End If

        If optTodos.Checked = True Then
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p1 where p1.idpoliza = s.idpoliza and p1.idproducto = s.idproducto and p1.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
        End If

        dim dtSin as datatable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        gridReclamos.DataSource = dtSin
        gridReclamos.refresh()
        

    End Sub

    Private Sub optAnioAct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optAnioAct.Click
        call CargarReclamos()
    End Sub

    Private Sub optAnioAnt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optAnioAnt.Click
        call CargarReclamos()
    End Sub

    Private Sub optTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optTodos.Click
        call CargarReclamos()
    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        vistaReclamos.PostEditor()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.cboClaseSiniestro.Valor = "" Then
            MsgBox("Debe seleccionar la clase de siniestro.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Dim RegistrosModificados As Integer = 0

        For I As Integer = 0 To Me.vistaReclamos.RowCount - 1
            If Me.vistaReclamos.GetRowCellValue(I, "Incluir") = True Then

                StiGlobalConn.SqlExecute("update siniestros set ClaseSiniestro = " & dbstr(cboClaseSiniestro.Valor,50) & " where IdPoliza = " & dbstr(vistaReclamos.GetRowCellValue(I, "IdPoliza")) & " and IdProducto = " & dbstr(vistaReclamos.GetRowCellValue(I, "IdProducto")) & " and IdCertificado = " & dbstr(vistaReclamos.GetRowCellValue(I, "Certificado")) & " and IdSiniestro = " & dbstr(vistaReclamos.GetRowCellValue(I, "IdSiniestro")))

                RegistrosModificados += 1
            End If
        Next

        'refrescamos
        If RegistrosModificados > 0 Then
            Me.CargarReclamos()
            MsgBox("Los reclamos han sido actualizados con éxito.", MsgBoxStyle.Information, "AVISO...")
        Else
            MsgBox("No se han marcado reclamos para actualizarse.", MsgBoxStyle.Information, "AVISO...")
        End If

    End Sub

End Class


