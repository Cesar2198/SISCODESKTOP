Imports Utilerias.Genericas

Public Class ProduccionResumen

    Private AnioBase As Integer
    Private Datos As DataTable

    Private Sub ProduccionResumen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GenerarDatos()
    End Sub

    Public Sub ActualizarDatos()
        GenerarDatos()
    End Sub

    Private Sub GenerarDatos()
        'Buscaremos los datos de tres años, en base a la fecha actual.
        Dim strSQL As String = ""

        'obtendremos el máximo año que esté presente en estadisticas
        Try
            'AnioBase = ModEstadisticas.ObtenerDataset("select max(Anio) from ESTADISTICASNET.DBO.EST_UNIVERSO_GENERAL_RES_RAMO").Tables(0).Rows(0).Item(0)
            AnioBase = AnioAnalisis
        Catch ex As Exception
            AnioBase = 0
        End Try
        Me.Cursor = Cursors.WaitCursor

        Dim ColumnaPrima As String = ""
        
        ColumnaPrima = " isnull(a.Prima,0.0)  "

        'ojo al usar union los datos iguales se ignoran debemos usar un identificador único en el query.

        Try
            strSQL = "  select "
            strSQL &= " a.Nombre as Cia"
            strSQL &= " , year(m.FechaMovimiento) as Anio"
            strSQL &= " , s.NombreMes as Mes"
            strSQL &= " , r.NombreRamo as Ramo"
            strSQL &= " , p.Descripcion as Grupo"
            strSQL &= " , sum(m.PrimaNeta) as Prima"
            strSQL &= " , sum(m.Comision) as Comision"
            strSQL &= " , 0.0 as Siniestros "
            strSQL &= " , 0.0 as Variacion"
            strSQL &= " , 0.0 as Siniestralidad"
            strSQL &= " from FacturasMovimientos as m"
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto "
            strSQL &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            strSQL &= " inner join Meses as s on s.idmes = month(m.FechaMovimiento)"
            strSQL &= " where year(m.FechaMovimiento) in (" & AnioBase & "," & AnioBase - 1 & ", " & AnioBase - 2 & ") "
            strSQL &= " and m.TipoMovimiento in ('EMISION','ANULACION') "
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by a.Nombre, year(m.FechaMovimiento), s.NombreMes, r.NombreRamo, p.Descripcion"

            strSQL &= " union "

            strSQL &= "  select "
            strSQL &= " a.Nombre as Cia"
            strSQL &= " , year(si.FechaPago) as Anio"
            strSQL &= " , s.NombreMes as Mes"
            strSQL &= " , r.NombreRamo as Ramo"
            strSQL &= " , p.Descripcion as Grupo"
            strSQL &= " , 0.0 as Prima"
            strSQL &= " , 0.0 as Comision"
            strSQL &= " , sum(si.ValorReembolso) as Siniestros "
            strSQL &= " , 0.0 as Variacion"
            strSQL &= " , 0.0 as Siniestralidad"
            strSQL &= " from SiniestrosPagos as si"
            strSQL &= " inner join Productos as p on p.idproducto = si.idproducto "
            strSQL &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            strSQL &= " inner join Meses as s on s.idmes = month(si.FechaPago)"
            strSQL &= " where year(si.FechaPago) in (" & AnioBase & "," & AnioBase - 1 & ", " & AnioBase - 2 & ") "
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = si.idpoliza and pol.idproducto = si.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by a.Nombre, year(si.FechaPago), s.NombreMes, r.NombreRamo, p.Descripcion"


            Datos = StiGlobalConn.ObtenerDataset(strSQL).Tables(0)
            Me.PivotGridControl1.DataSource = Nothing : Me.PivotGridControl1.Refresh()
            Me.PivotGridControl1.DataSource = Datos
            Me.PivotGridControl1.Refresh()
            Call PivotGridControl1_FieldFilterChanged(Nothing, Nothing)
        Catch ex As Exception
            msgError(ex)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub Exportar()
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\DatosGen.xls"
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
        Try

            'Try
            '    If e.FieldName = "Variacion" Then
            '        Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            '        Dim Anio1 As Double = 0, Anio2 As Double = 0
            '        Dim An1 As Integer, An2 As Integer
            '        Dim i As Integer = 0
            '        An1 = e.ColumnFieldValue
            '        An2 = An1 - 1

            '        For i = 0 To ds.RowCount - 1
            '            Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
            '            If row("Anio") = An1 Then
            '                Anio1 += Val(row("Prima"))
            '            End If
            '            If row("Anio") <> An1 Then
            '                Anio2 += Val(row("Prima"))
            '            End If
            '        Next
            '        If Anio2 = 0 Then
            '            e.CustomValue = 100
            '        Else
            '            ''e.CustomValue = (Anio1 - Anio2) / Anio2
            '            e.CustomValue = Anio1
            '        End If

            '    End If
            'Catch ex As Exception

            'End Try




            If Not e.ColumnField Is Nothing Then
                If e.ColumnField.FieldName = "Anio" Then
                    Select Case e.FieldName
                        Case "Variacion"
                            Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                            Dim Anio1 As Double = 0, Anio2 As Double = 0
                            Dim An1 As Integer, An2 As Integer
                            Dim i As Integer = 0
                            An1 = e.ColumnFieldValue
                            An2 = An1 - 1

                            For i = 0 To ds.RowCount - 1
                                Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
                                If row("Anio") = An1 Then
                                    Anio1 += Val(row("Prima"))
                                End If
                            Next
                            Try
                                ''ojo debemos filtrar por los datos de las filas, aqui esta el total del anio
                                Anio2 = Datos.Compute("sum(Prima)", "Anio=" & dbInt(An2))
                            Catch ex As Exception
                                Anio2 = 0
                            End Try


                            If Anio2 = 0 Then
                                e.CustomValue = 1
                            Else
                                e.CustomValue = (Anio1 - Anio2) / Anio2
                                ''e.CustomValue = Anio1
                            End If
                        Case "Siniestralidad"
                            Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                            Dim Prima As Double = 0, Siniestros As Double = 0
                            For i = 0 To ds.RowCount - 1
                                Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
                                Prima += Val(row("Prima"))
                                Siniestros += Val(row("Siniestros"))
                            Next
                            If Prima = 0 Then
                                If Siniestros > 0 Then
                                    e.CustomValue = 1
                                Else
                                    e.CustomValue = 0
                                End If
                            Else
                                e.CustomValue = Siniestros / Prima
                            End If
                        Case Else
                            e.CustomValue = e.SummaryValue.Summary
                    End Select
                End If
            Else
                'suma por fila
                Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                
                Dim Anio1 As Double = 0, Anio2 As Double = 0
                Dim i As Integer
                For i = 0 To ds.RowCount - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
                    If row("Anio") = AnioBase Then
                        Anio1 += Val(row("Prima"))
                    End If
                    If row("Anio") = AnioBase - 1 Then
                        Anio2 += Val(row("Prima"))
                    End If

                Next
                e.CustomValue = Anio1 - Anio2
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub PivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PivotGridControl1.FieldValueDisplayText
        Try
            If e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal Then
                If e.IsColumn = True Then
                    e.DisplayText = "DIFERENCIA"
                Else
                    e.DisplayText = "TOTAL GENERAL"
                End If

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