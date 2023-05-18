Imports Utilerias.Genericas

Public Class EstadisticasPolizas
    Private AnioBase As Integer
    Dim Datos As DataSet

    Private Sub EstadisticasPolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GenerarDatos()
    End Sub

    Public Sub ActualizarDatos()
        GenerarDatos()
    End Sub

    Private Sub GenerarDatos()
        'obtendremos el máximo año que esté presente en estadisticas
        Try
            AnioBase = AnioAnalisis
        Catch ex As Exception
            AnioBase = 0
        End Try

        Me.Cursor = Cursors.WaitCursor
        'Buscaremos los datos de tres años, en base a la fecha actual.
        Dim strSQL As String = ""

        Try
            strSQL = "  select "

            strSQL &= "  'POL' as Tipo"
            strSQL &= "  ,pol.IdPoliza as DocControl"
            strSQL &= " , a.Nombre as Cia"
            strSQL &= " , year(pol.VigenciaDesde) as Anio"
            strSQL &= " , s.NombreMes as Mes"
            strSQL &= " , r.NombreRamo as Ramo"
            strSQL &= " , p.Descripcion as Grupo"
            strSQL &= " , isnull(u.NombreUsuario,'') AS Director"
            strSQL &= " , pol.NombreCliente as Cliente"
            strSQL &= " , case c.IdTipoCliente when 'NA' then 'Natural' when 'JU' then 'Persona Jurídica' when 'GU' then 'Gubernamental' when 'GA' then 'Gubernamental Autónoma' when 'JE' then 'Persona Jurídica Exenta' else '' end as TipoCliente"
            strSQL &= " , isnull(v.NombreVendedor,'') as Vendedor"
            strSQL &= " , pol.EstadoPoliza as Estado"
            strSQL &= " , 1 as NumPolizas"
            strSQL &= " , 0 as NumSiniestros "
            strSQL &= " , 0.0 as ParticipaPol "
            strSQL &= " , 0.0 as ParticipaSin "
            strSQL &= " , isnull((select sum(m.PrimaNeta) from FacturasMovimientos as m where m.IdProducto = pol.idproducto and m.IdPoliza = pol.idpoliza and m.FechaMovimiento >= pol.vigenciadesde and m.fechamovimiento < pol.vigenciahasta and TipoMovimiento in ('EMISION','ANULACION')),0) as Primas"
            strSQL &= " , 0.0 as Siniestros"
            strSQL &= " , pol.idpoliza as IdPoliza"
            strSQL &= " from Polizas as pol "
            strSQL &= " inner join Productos as p on p.idproducto = pol.idproducto  "
            strSQL &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = p.idramo "
            strSQL &= " inner join Meses as s on s.idmes = month(pol.VigenciaDesde)"
            strSQL &= " left join Clientes as c on c.IdCliente = pol.IdCliente "
            strSQL &= " left join Usuarios as u on u.IdUsuario = c.EjecutivoCta"
            strSQL &= " left join Vendedores as v on v.idvendedor = pol.idvendedor"
            strSQL &= " where year(pol.VigenciaDesde) in (" & AnioBase & "," & AnioBase - 1 & ", " & AnioBase - 2 & ") "
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and pol.Departamento = " & dbStr(DepartamentoUsuario())
            End If
            strSQL &= " union "

            strSQL &= "  select "
            strSQL &= "  'SIN' as Tipo"
            strSQL &= "  ,sin.IdSiniestro as DocControl"
            strSQL &= " , a.Nombre as Cia"
            strSQL &= " , year(sin.FechaOcurrido) as Anio"
            strSQL &= " , s.NombreMes as Mes"
            strSQL &= " , r.NombreRamo as Ramo"
            strSQL &= " , p.Descripcion as Grupo"
            strSQL &= " , isnull(u.NombreUsuario,'') AS Director"
            strSQL &= " , pol.NombreCliente as Cliente"
            strSQL &= " , case c.IdTipoCliente when 'NA' then 'Natural' when 'JU' then 'Persona Jurídica' when 'GU' then 'Gubernamental' when 'GA' then 'Gubernamental Autónoma' when 'JE' then 'Persona Jurídica Exenta' else '' end as TipoCliente"
            strSQL &= " , isnull(v.NombreVendedor,'') as Vendedor"
            strSQL &= " , pol.EstadoPoliza as Estado"
            strSQL &= " , 0 as NumPolizas"
            strSQL &= " , 1 as NumSiniestros "
            strSQL &= " , 0.0 as ParticipaPol "
            strSQL &= " , 0.0 as ParticipaSin "
            strSQL &= " , 0.0 as Primas"
            strSQL &= " , sin.TotalReembolso as Siniestros"
            strSQL &= " , sin.idpoliza as IdPoliza"
            strSQL &= " from siniestros as sin"
            strSQL &= " left join polizas as pol on pol.idpoliza = sin.idpoliza and pol.idproducto = sin.idproducto"
            strSQL &= " inner join Productos as p on p.idproducto = sin.idproducto  "
            strSQL &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = p.idramo "
            strSQL &= " inner join Meses as s on s.idmes = month(sin.FechaOcurrido)"
            strSQL &= " left join Clientes as c on c.IdCliente = pol.IdCliente "
            strSQL &= " left join Usuarios as u on u.IdUsuario = c.EjecutivoCta"
            strSQL &= " left join Vendedores as v on v.idvendedor = pol.idvendedor"
            strSQL &= " where year(sin.FechaOcurrido) in (" & AnioBase & "," & AnioBase - 1 & ", " & AnioBase - 2 & ") "
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and pol.Departamento = " & dbStr(DepartamentoUsuario())
            End If

            Datos = StiGlobalConn.ObtenerDataset(strSQL)
            Me.PivotGridControl1.DataSource = Nothing : Me.PivotGridControl1.Refresh()
            Me.PivotGridControl1.DataSource = Datos.Tables(0)
            Me.PivotGridControl1.Refresh()
            Call PivotGridControl1_FieldFilterChanged(Nothing, Nothing)
        Catch ex As Exception
            msgError(ex)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Public Sub Exportar()
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\DatosPol.xls"
            PivotGridControl1.ExportToXls(Archivo, True)
            PrepararArchivoExcel(Archivo, Me.lblNombre.Text, Me.lblFiltro.Text, "Reporte al " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss") & " " & System.Security.Principal.WindowsIdentity.GetCurrent.Name, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub BestFit()
        Try
            Me.PivotGridControl1.BestFit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PivotGridControl1_CustomFieldSort(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomFieldSortEventArgs) Handles PivotGridControl1.CustomFieldSort
        Try
            If e.Value1 Is Nothing OrElse e.Value2 Is Nothing Then
                Return
            End If
            e.Handled = True

            Dim s1 As Integer = 0, S2 As Integer = 0
            If e.Field.FieldName = "Mes" Then
                s1 = OrdenarMes(e.Value1.ToString())
                S2 = OrdenarMes(e.Value2.ToString())
            End If

            If s1 > S2 Then
                e.Result = 1
            Else
                If s1 = S2 Then
                    e.Result = Comparer(Of Int32).Default.Compare(s1, S2)
                Else
                    e.Result = -1
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotGridControl1.CustomSummary
        'calcularemos la participación
        Try
            If e.FieldName = "ParticipaPol" Then
                Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim Total As Double = 0, An1 As Integer
                Dim Num As Integer = 0
                Dim i As Integer = 0
                'siempre se agrupa por anio
                Try
                    An1 = e.ColumnFieldValue
                Catch ex As Exception
                    An1 = 0
                End Try

                For i = 0 To ds.RowCount - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
                    Num += Val(row("NumPolizas"))
                Next
                If An1 > 0 Then
                    Total = Datos.Tables(0).Compute("SUM(NumPolizas)", "Anio = " & dbInt(An1))
                Else
                    Total = Datos.Tables(0).Compute("SUM(NumPolizas)", "")
                End If

            
                If Total = 0 Then
                    e.CustomValue = 0
                Else
                    e.CustomValue = Num / Total
                End If
            End If
        Catch ex As Exception

        End Try
        Try
            If e.FieldName = "ParticipaSin" Then
                Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim Total As Double = 0, An1 As Integer
                Dim Num As Integer = 0
                Dim i As Integer = 0
                'siempre se agrupa por anio
                Try
                    An1 = e.ColumnFieldValue
                Catch ex As Exception
                    An1 = 0
                End Try

                For i = 0 To ds.RowCount - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
                    Num += Val(row("NumSiniestros"))
                Next
                If An1 > 0 Then
                    Total = Datos.Tables(0).Compute("SUM(NumSiniestros)", "Anio = " & dbInt(An1))
                Else
                    Total = Datos.Tables(0).Compute("SUM(NumSiniestros)", "")
                End If


                If Total = 0 Then
                    e.CustomValue = 0
                Else
                    e.CustomValue = Num / Total
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("ss")
        End Try
    End Sub

    Private Sub PivotGridControl1_FieldFilterChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles PivotGridControl1.FieldFilterChanged
        lblFiltro.Text = ""
        For Each Columna As DevExpress.XtraPivotGrid.PivotGridField In PivotGridControl1.Fields
            'las columnas del area de datos no se usan
            If Columna.Area <> DevExpress.XtraPivotGrid.PivotArea.DataArea Then
                If Columna.FilterValues.Values.Length > 0 Or Columna.FieldName = "Anio" Then
                    lblFiltro.Text &= Columna.Caption & "="
                    For i As Integer = 0 To Columna.FilterValues.ValuesIncluded.Length - 1
                        lblFiltro.Text &= Columna.FilterValues.ValuesIncluded(i).ToString.Trim & ", "
                    Next
                Else
                    lblFiltro.Text &= Columna.Caption & "=Todos, "
                End If
            End If
        Next

        lblFiltro.Text = "Para: " & lblFiltro.Text

    End Sub

End Class