Imports Utilerias.Genericas

Public Class ProduccionClientes
    Private AnioBase As Integer
    Dim Datos As New DataSet

    Private Sub ProduccionClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            strSQL &= "  a.Nombre as Cia"
            strSQL &= " , year(m.FechaMovimiento) as Anio"
            strSQL &= " , s.NombreMes as Mes"
            strSQL &= " , r.NombreRamo as Ramo"
            strSQL &= " , p.Descripcion as Grupo"
            strSQL &= " , isnull(u.NombreUsuario,'') AS Director"
            strSQL &= " , f.NombreCliente as Cliente"
            strSQL &= " , case c.IdTipoCliente when 'NA' then 'Natural' when 'JU' then 'Persona Jurídica' when 'GU' then 'Gubernamental' when 'GA' then 'Gubernamental Autónoma' when 'JE' then 'Persona Jurídica Exenta' else '' end as TipoCliente"
            strSQL &= " , v.NombreVendedor as Vendedor"
            strSQL &= " , f.IdPoliza"
            strSQL &= " , sum(m.primaneta) as Prima "
            strSQL &= " , sum(m.comision) as Comision "
            strSQL &= " , 0.0 as Siniestros "
            strSQL &= " , 0.0 as Participacion"
            strSQL &= " , 0.0 as ParticipacionSini"
            strSQL &= " , 0.0 as Siniestralidad"
            strSQL &= " , 0.0 as Rentabilidad"
            strSQL &= " from Facturas as f"
            strSQL &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo"
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto  "
            strSQL &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = p.idramo "
            strSQL &= " inner join Meses as s on s.idmes = month(m.FechaMovimiento)"
            strSQL &= " left join Clientes as c on c.IdCliente = f.IdCliente "
            strSQL &= " left join Usuarios as u on u.IdUsuario = c.EjecutivoCta"
            strSQL &= " left join Polizas as pol on pol.idproducto = f.idproducto and pol.idpoliza = f.idpoliza"
            strSQL &= " left join Vendedores as v on v.idvendedor = pol.idvendedor"
            strSQL &= " where year(m.FechaMovimiento) in (" & AnioBase & "," & AnioBase - 1 & ", " & AnioBase - 2 & ") "
            strSQL &= " and m.TipoMovimiento in ('EMISION','ANULACION') "
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by a.Nombre, year(m.FechaMovimiento), s.NombreMes, r.NombreRamo, p.Descripcion, isnull(u.NombreUsuario,''), f.NombreCliente, c.IdTipoCliente, v.NombreVendedor, f.IdPoliza"

            strSQL &= " union "

            strSQL &= "  select "
            strSQL &= "  a.Nombre as Cia"
            strSQL &= " , year(si.FechaPago)  as Anio"
            strSQL &= " , s.NombreMes as Mes"
            strSQL &= " , r.NombreRamo as Ramo"
            strSQL &= " , p.Descripcion as Grupo"
            strSQL &= " , isnull(u.NombreUsuario,'') AS Director"
            strSQL &= " , pol.NombreCliente as Cliente"
            strSQL &= " , case c.IdTipoCliente when 'NA' then 'Natural' when 'JU' then 'Persona Jurídica' when 'GU' then 'Gubernamental' when 'GA' then 'Gubernamental Autónoma' when 'JE' then 'Persona Jurídica Exenta' else '' end as TipoCliente"
            strSQL &= " , v.NombreVendedor as Vendedor"
            strSQL &= " , si.IdPoliza"
            strSQL &= " , 0.0 as Prima "
            strSQL &= " , 0.0 as Comision "
            strSQL &= " , sum(si.ValorReembolso) as Siniestros "
            strSQL &= " , 0.0 as ParticipacionSini"
            strSQL &= " , 0.0 as Participacion"
            strSQL &= " , 0.0 as Siniestralidad"
            strSQL &= " , 0.0 as Rentabilidad"
            strSQL &= " from SiniestrosPagos as si"
            strSQL &= " inner join Productos as p on p.idproducto = si.idproducto  "
            strSQL &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = p.idramo "
            strSQL &= " inner join Meses as s on s.idmes = month(si.FechaPago)"
            strSQL &= " left join Polizas as pol on pol.idproducto = si.idproducto and pol.idpoliza = si.idpoliza"
            strSQL &= " left join Clientes as c on c.IdCliente = pol.IdCliente "
            strSQL &= " left join Usuarios as u on u.IdUsuario = c.EjecutivoCta"
            strSQL &= " left join Vendedores as v on v.idvendedor = pol.idvendedor"
            strSQL &= " where year(si.FechaPago) in (" & AnioBase & "," & AnioBase - 1 & ", " & AnioBase - 2 & ") "
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and pol.Departamento = " & dbStr(DepartamentoUsuario())
            End If
            strSQL &= " group by a.Nombre, year(si.FechaPago), s.NombreMes, r.NombreRamo, p.Descripcion, isnull(u.NombreUsuario,''), pol.NombreCliente, c.IdTipoCliente, v.NombreVendedor, si.IdPoliza"

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
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\DatosCli.xls"
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
            If e.FieldName = "Participacion" Then
                Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim Anio1 As Double = 0, Total As Double = 0
                Dim An1 As Integer
                Dim i As Integer = 0
                'siempre se agrupa por anio
                Try
                    An1 = e.ColumnFieldValue
                Catch ex As Exception
                    An1 = 0
                End Try

                For i = 0 To ds.RowCount - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
                    Anio1 += Val(row("Prima"))
                Next
                'ahora el total del anio
                If An1 > 0 Then
                    Total = Datos.Tables(0).Compute("SUM(prima)", "Anio = " & dbInt(An1))
                Else
                    Total = Datos.Tables(0).Compute("SUM(prima)", "")
                End If

                If Total = 0 Then
                    e.CustomValue = 0
                Else
                    e.CustomValue = Anio1 / Total
                End If
            End If
        Catch ex As Exception

        End Try
        Try
            If e.FieldName = "ParticipacionSini" Then
                Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim Anio1 As Double = 0, Total As Double = 0
                Dim An1 As Integer
                Dim i As Integer = 0
                'siempre se agrupa por anio
                Try
                    An1 = e.ColumnFieldValue
                Catch ex As Exception
                    An1 = 0
                End Try

                For i = 0 To ds.RowCount - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
                    Anio1 += Val(row("Siniestros"))
                Next
                'ahora el total del anio
                If An1 > 0 Then
                    Total = Datos.Tables(0).Compute("SUM(Siniestros)", "Anio = " & dbInt(An1))
                Else
                    Total = Datos.Tables(0).Compute("SUM(Siniestros)", "")
                End If

                If Total = 0 Then
                    e.CustomValue = 0
                Else
                    e.CustomValue = Anio1 / Total
                End If
            End If
        Catch ex As Exception

        End Try

        Try
            If e.FieldName = "Siniestralidad" Or e.FieldName = "Rentabilidad" Then
                
                Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim Primas As Double = 0, Siniestros As Double = 0
                Dim Siniestralidad As Double = 0

                For i = 0 To ds.RowCount - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
                    Primas += Val(row("Prima"))
                    Siniestros += Val(row("Siniestros"))
                Next

                Select Case e.FieldName
                    Case "Siniestralidad"
                        If Primas = 0 Then
                            Siniestralidad = 1
                        Else
                            Siniestralidad = Siniestros / Primas
                        End If
                    Case "Rentabilidad"
                        If Siniestros = 0 Then
                            Siniestralidad = 1
                        Else
                            Siniestralidad = Primas / Siniestros
                        End If
                End Select
                e.CustomValue = Siniestralidad
            End If
        Catch ex As Exception

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