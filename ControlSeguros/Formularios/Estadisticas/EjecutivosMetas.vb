Imports Utilerias.Genericas

Public Class EjecutivosMetas
    Private AnioBase As Integer = 0

    Private Sub EjecutivosMetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GenerarDatos()

        'por defecto contraemos por mes y expandimos el mes en curso
        PivotGridField3.CollapseAll()
        'OBTENDREMOS EL MES ACTUAL
        Dim Mes As String
        Try
            Mes = StiGlobalConn.ObtenerDataset("select rtrim(NombreMes) from Meses where IdMes = " & Date.Today.Month).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Mes = ""
        End Try
        PivotGridField3.ExpandValue(Mes)
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
            strSQL = "  select  "
            strSQL &= " year(m.fechamovimiento) as Anio"
            strSQL &= " ,s.NombreMes as Mes"
            strSQL &= " ,r.NombreRamo as Ramo"
            strSQL &= " ,isnull(u.NombreUsuario,'') as Director"
            strSQL &= " ,p.TipoProducto as Cia"
            strSQL &= " ,p.Descripcion as Grupo"
            strSQL &= " ,sum(m.PrimaNeta) as Prima"
            strSQL &= " ,0.0 as Meta"
            strSQL &= " ,0.0 AS Cumplimiento"
            strSQL &= " ,0.00 as Difrencia"
            strSQL &= " from Facturas as f"
            strSQL &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo"
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto "
            strSQL &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            strSQL &= " inner join Meses as s on s.idmes = month(m.fechamovimiento) "
            strSQL &= " left join Clientes as c on c.idcliente = f.idcliente"
            strSQL &= " left join Usuarios as u on u.IdUsuario = c.EjecutivoCta"
            strSQL &= " where year(m.fechamovimiento) in (" & AnioBase & "," & AnioBase - 1 & ") "
            strSQL &= " and m.TipoMovimiento in ('EMISION','ANULACION') "
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by year(m.fechamovimiento), s.NombreMes, r.NombreRamo, isnull(u.NombreUsuario,''), p.TipoProducto, p.Descripcion "

            strSQL &= " union "

            strSQL &= " select "
            strSQL &= " m.Anio"
            strSQL &= " ,s.NombreMes as Mes"
            strSQL &= " ,r.NombreRamo as Ramo"
            strSQL &= " ,isnull(u.NombreUsuario,'') as Director"
            strSQL &= " ,'' as Cia"
            strSQL &= " ,'' as Grupo"
            strSQL &= " ,0.0 as Prima"
            strSQL &= " ,sum(m.Primas) as Meta"
            strSQL &= " ,0.0 AS Cumplimiento"
            strSQL &= " ,0.00 as Difrencia"
            strSQL &= " from Metas as m "
            strSQL &= " inner join Meses as s on s.idmes = m.Mes "
            strSQL &= " left join RamoSeguros as r on r.idramo = m.idramo"
            strSQL &= " left join usuarios as u on u.idusuario = m.EjecutivoCta"
            strSQL &= " where m.Anio in (" & AnioBase & "," & AnioBase - 1 & ") "
            strSQL &= " group by m.Anio, s.NombreMes, r.NombreRamo, isnull(u.NombreUsuario,'') "
            
            Dim ds As DataSet = StiGlobalConn.ObtenerDataset(strSQL)
            Me.PivotGridControl1.DataSource = Nothing : Me.PivotGridControl1.Refresh()
            Me.PivotGridControl1.DataSource = ds.Tables(0)
            Me.PivotGridControl1.Refresh()

            Try
                'todos los filtros son de tipo que se excluye, colocamos el años que no queremos mostrar
                'cargamos por defecto el año actual
                PivotGridField2.FilterValues.Clear()
                PivotGridField2.FilterValues.Add(AnioBase - 1)

            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
        
        Me.Cursor = Cursors.Default
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
        Dim name As String = e.DataField.FieldName
        'Para calcular el cumplimiento
        'la formula (prima / meta) * 100
        Dim TotPrima As Double = 0, TotMeta As Double = 0

        If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
            Dim list As IList = e.CreateDrillDownDataSource()
            For i As Integer = 0 To list.Count - 1
                Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)
                Try
                    TotPrima += Val(row("Prima"))
                Catch ex As Exception

                End Try
                Try
                    TotMeta += Val(row("Meta"))
                Catch ex As Exception

                End Try
            Next

            Select Case name
                Case "Cumplimiento"
                    Try
                        If TotMeta = 0 Then
                            e.CustomValue = 0
                        Else
                            e.CustomValue = (TotPrima / TotMeta)
                        End If
                    Catch ex As Exception
                        'si no hay meta lo dejamos a cero
                        e.CustomValue = 0
                    End Try

                Case "Diferencia"
                    Try
                        e.CustomValue = TotPrima - TotMeta
                    Catch ex As Exception
                        'si no hay meta lo dejamos a cero
                        e.CustomValue = 0
                    End Try
            End Select
        End If
    End Sub

    Private Sub PivotGridControl1_FieldFilterChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles PivotGridControl1.FieldFilterChanged
        lblFiltro.Text = ""
        For Each Columna As DevExpress.XtraPivotGrid.PivotGridField In PivotGridControl1.Fields
            'las columnas del area de datos no se usan
            If Columna.Area <> DevExpress.XtraPivotGrid.PivotArea.DataArea Or Columna.FieldName = "Anio" Then
                If Columna.FilterValues.Values.Length > 0 Then
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

    Public Sub Exportar()
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\DatosMeta.xls"
            PivotGridControl1.ExportToXls(Archivo, True)
            PrepararArchivoExcel(Archivo, Me.lblNombre.Text, Me.lblFiltro.Text, "Reporte al " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss") & " " & System.Security.Principal.WindowsIdentity.GetCurrent.Name, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("No se puede exportar los datos, verifique que no tienen abierto un cuadro de excel del mismo reporte")
        End Try
    End Sub

    Public Sub BestFit()
        Try
            Me.PivotGridControl1.BestFit()
        Catch ex As Exception

        End Try
    End Sub

End Class