Imports Utilerias.Genericas

Public Class EstadisticaTecnica
    Private Datos As DataTable
    Private TotDif As Double = 0
    Private TotExc As Double = 0
    Dim MinCustomTotal As Integer = 0
    Dim MinCustomTotalData As Integer = 0
    Dim AnioBase As Integer = 0


    Private Sub EstadisticaTecnica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GenerarDatos()
    End Sub

    Public Sub ActualizarDatos()
        GenerarDatos()
    End Sub

    Private Sub GenerarDatos()
        Try
            AnioBase = AnioAnalisis
        Catch ex As Exception
            AnioBase = 0
        End Try
        Me.Cursor = Cursors.WaitCursor

        'Buscaremos los datos de tres años, en base a la fecha actual.
        Dim strSQL As String = ""
        

        'ojo al usar union los datos iguales se ignoran debemos usar un identificador único en el query.

        Try
            'INCLUIREMOS LAS METAS  **********************************************************************************

            strSQL = "  select  "
            strSQL &= "   m.Anio"
            strSQL &= " , s.nombremes as Mes"
            strSQL &= " , r.NombreRamo as Ramo"
            strSQL &= " , u.NombreUsuario AS Director"
            strSQL &= " , g.Descripcion as Grupo2"
            strSQL &= " , 0.0 as Prima"
            strSQL &= " , sum(m.Primas) as Meta"
            strSQL &= " , 0.0 AS Cumplimiento"
            strSQL &= " , 0.0 as Autos"
            strSQL &= " , 0.0 as Fianzas"
            strSQL &= " , 0.0 as Danos"
            strSQL &= " , 0.0 as Personas"
            strSQL &= " , 0.0 as AnioAnt"
            strSQL &= " from Metas as m"
            strSQL &= " inner join Meses as s on s.idmes = m.mes"
            strSQL &= " left join RamoSeguros as r on r.idramo = m.idramo "
            strSQL &= " left join RamosGrupos as g on g.IdGrupoRamo = r.IdGrupoRamo"
            strSQL &= " left join Usuarios as u on u.idusuario = m.EjecutivoCta"
            
            strSQL &= " where m.Anio = " & AnioBase
            strSQL &= " group by m.Anio, s.nombremes, r.NombreRamo, u.NombreUsuario, g.Descripcion"

            strSQL &= " union "     'INCLUIMOS LAS PRIMAS PRODUCCION   ***********************************************


            strSQL &= "  select  "
            strSQL &= "   year(m.fechamovimiento) as Anio"
            strSQL &= " , s.nombremes as Mes"
            strSQL &= " , r.NombreRamo as Ramo"
            strSQL &= " , u.NombreUsuario AS Director"
            strSQL &= " , g.Descripcion as Grupo2"
            strSQL &= " , sum(m.primaneta) as Prima"
            strSQL &= " , 0.0 as Meta"
            strSQL &= " , 0.0 AS Cumplimiento"
            strSQL &= " , case g.IdGrupoRamo when 'A' then isnull(sum(m.primaneta) ,0.0) else 0.00 end as Autos"
            strSQL &= " , case g.IdGrupoRamo when 'F' then isnull(sum(m.primaneta) ,0.0) else 0.00 end as Fianzas"
            strSQL &= " , case g.IdGrupoRamo when 'D' then isnull(sum(m.primaneta) ,0.0) else 0.00 end as Danos"
            strSQL &= " , case g.IdGrupoRamo when 'P' then isnull(sum(m.primaneta) ,0.0) else 0.00 end as Personas"
            strSQL &= " , 0.0 as AnioAnt"

            strSQL &= " from Facturas as f"
            strSQL &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo"
            strSQL &= " inner join Meses as s on s.idmes = month(m.fechamovimiento)"
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto"
            strSQL &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            strSQL &= " inner join RamosGrupos as g on g.IdGrupoRamo = r.IdGrupoRamo"
            strSQL &= " left join Clientes as c on c.idcliente = f.idcliente"
            strSQL &= " left join Usuarios as u on u.idusuario = c.EjecutivoCta"
            strSQL &= " where year(m.fechamovimiento) = " & AnioBase
            strSQL &= " and m.TipoMovimiento in ('EMISION','ANULACION')"
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by year(m.fechamovimiento), s.nombremes, r.NombreRamo, u.NombreUsuario, g.IdGrupoRamo, g.Descripcion"


            'OJO SE HACE OTRO QUERY POR QUE HAY RAMOS O ANEXOS QUE NO ESTAN EN EL MISMO AÑO Y DEBE DE CUADRAR
            strSQL &= " union "     'INCLUIMOS LAS PRIMAS PRODUCCION ANO ANTERIOR  ***********************************************

            strSQL &= "  select  "
            strSQL &= "   year(m.fechamovimiento) + 1 as Anio"
            strSQL &= " , s.nombremes as Mes"
            strSQL &= " , r.NombreRamo as Ramo"
            strSQL &= " , u.NombreUsuario AS Director"
            strSQL &= " , g.Descripcion as Grupo2"
            strSQL &= " , 0.0 as Prima"
            strSQL &= " , 0.0 as Meta"
            strSQL &= " , 0.0 AS Cumplimiento"
            strSQL &= " , 0.0 as Autos"
            strSQL &= " , 0.0 as Fianzas"
            strSQL &= " , 0.0 as Danos"
            strSQL &= " , 0.0 as Personas"
            strSQL &= " , sum(m.primaneta) as AnioAnt"

            strSQL &= " from Facturas as f"
            strSQL &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo"
            strSQL &= " inner join Meses as s on s.idmes = month(m.fechamovimiento)"
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto"
            strSQL &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            strSQL &= " inner join RamosGrupos as g on g.IdGrupoRamo = r.IdGrupoRamo"
            strSQL &= " left join Clientes as c on c.idcliente = f.idcliente"
            strSQL &= " left join Usuarios as u on u.idusuario = c.EjecutivoCta"
            strSQL &= " where year(m.fechamovimiento) = " & AnioBase - 1
            strSQL &= " and m.TipoMovimiento in ('EMISION','ANULACION')"
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by year(m.fechamovimiento), s.nombremes, r.NombreRamo, u.NombreUsuario, g.IdGrupoRamo, g.Descripcion"


            MinCustomTotal = 0 : MinCustomTotalData = 0
            Datos = StiGlobalConn.ObtenerDataset(strSQL).Tables(0)
            Me.PivotGridControl1.DataSource = Nothing : Me.PivotGridControl1.Refresh()
            Me.PivotGridControl1.DataSource = Datos
            Me.PivotGridControl1.Refresh()

            'tomaremos el año como base para los subtotales
            PivotGridField2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
            PivotGridField2.CustomTotals.Clear()
            PivotGridField2.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Custom)
            PivotGridField2.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Custom)
            PivotGridField2.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Custom)
            PivotGridField2.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Custom)
            PivotGridField2.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Custom)
            PivotGridField2.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Custom)
            PivotGridField2.CustomTotals.Add(DevExpress.Data.PivotGrid.PivotSummaryType.Custom)
            Call PivotGridControl1_FieldFilterChanged(Nothing, Nothing)

        Catch ex As Exception
            msgError(ex)

        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles PivotGridControl1.CustomCellDisplayText
        Try

            If e.RowField.FieldName = "Anio" Then
                If e.RowValueType = DevExpress.XtraPivotGrid.PivotGridValueType.CustomTotal Then
                    If Me.MinCustomTotalData = 0 Then MinCustomTotalData = e.RowIndex
                    Dim Grupo As String = ""

                    Grupo = e.DataField.FieldName.ToUpper
                    If Grupo = "DANOS" Then Grupo = "DAÑOS"
                    If Grupo = "TOTAL" Then Grupo = ""

                    Select Case e.RowIndex
                        Case Me.MinCustomTotalData          'TOTAL
                            'ESTA COLUMNA ES LA CALCULADA EN CustomSummary EVENT

                        Case Me.MinCustomTotalData + 1      'PRESUPUESTO
                            Select Case e.DataField.FieldName
                                Case "Autos", "Personas", "Danos", "Fianzas", "Total"
                                    'calculamos el presupuesto por area
                                    Dim list As IList = e.CreateDrillDownDataSource(), TotM As Double = 0
                                    For i As Integer = 0 To list.Count - 1
                                        Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)
                                        Try
                                            If Grupo = "" Or Grupo = row("Grupo2") Then
                                                TotM += Val(row("Meta"))
                                            End If
                                        Catch ex As Exception

                                        End Try
                                    Next
                                    e.DisplayText = Format(TotM, "$#,###0.00")
                                Case Else
                                    'estos datos no se calculan
                                    e.DisplayText = ""
                            End Select
                        Case Me.MinCustomTotalData + 2      '% ALCANZADO
                            Select Case e.DataField.FieldName
                                Case "Autos", "Personas", "Danos", "Fianzas", "Total"
                                    Dim list As IList = e.CreateDrillDownDataSource(), TotP As Double = 0, TotM As Double = 0
                                    For i As Integer = 0 To list.Count - 1
                                        Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)
                                        Try
                                            If Grupo = "" Or Grupo = row("Grupo2") Then
                                                TotP += Val(row("Prima"))
                                                TotM += Val(row("Meta"))
                                            End If
                                        Catch ex As Exception

                                        End Try
                                    Next
                                    If TotM = 0 Then
                                        e.DisplayText = "0.00%"
                                    Else
                                        e.DisplayText = Format((TotP / TotM), "#,###0.00%")
                                    End If
                                Case Else
                                    'estos datos no se calculan
                                    e.DisplayText = ""
                            End Select

                        Case Me.MinCustomTotalData + 3      'PARTICIPACION
                            Select Case e.DataField.FieldName
                                Case "Autos", "Personas", "Danos", "Fianzas", "Total"
                                    Dim list As IList = e.CreateDrillDownDataSource(), TotM As Double = 0
                                    For i As Integer = 0 To list.Count - 1
                                        Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)
                                        Try
                                            If Grupo = "" Or Grupo = row("Grupo2") Then
                                                TotM += Val(row("Meta"))
                                            End If
                                        Catch ex As Exception

                                        End Try
                                    Next
                                    Dim GranTotalMeta As Double = Datos.Compute("SUM(Meta)", FiltroGrobal)
                                    If GranTotalMeta = 0 Then
                                        e.DisplayText = Format(0.0, "#,###0.00%")
                                    Else
                                        e.DisplayText = Format(TotM / GranTotalMeta, "#,###0.00%")
                                    End If
                                Case Else
                                    'estos datos no se calculan
                                    e.DisplayText = ""
                            End Select
                        Case Me.MinCustomTotalData + 4      'POR CUMPLIR
                            Select Case e.DataField.FieldName
                                Case "Autos", "Personas", "Danos", "Fianzas", "Total"
                                    Dim list As IList = e.CreateDrillDownDataSource(), TotP As Double = 0, TotM As Double = 0
                                    For i As Integer = 0 To list.Count - 1
                                        Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)
                                        Try
                                            If Grupo = "" Or Grupo = row("Grupo2") Then
                                                TotP += Val(row("Prima"))
                                                TotM += Val(row("Meta"))
                                            End If
                                        Catch ex As Exception

                                        End Try
                                    Next
                                    If TotM - TotP < 0 Then
                                        e.DisplayText = Format(0.0, "$#,###0.00")
                                    Else
                                        e.DisplayText = Format(TotM - TotP, "$#,###0.00")
                                    End If
                                Case Else
                                    'estos datos no se calculan
                                    e.DisplayText = ""
                            End Select

                        Case Me.MinCustomTotalData + 5      'EXCEDENTE
                            Select Case e.DataField.FieldName
                                Case "Autos", "Personas", "Danos", "Fianzas", "Total"
                                    Dim list As IList = e.CreateDrillDownDataSource(), TotP As Double = 0, TotM As Double = 0
                                    For i As Integer = 0 To list.Count - 1
                                        Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)
                                        Try
                                            If Grupo = "" Or Grupo = row("Grupo2") Then
                                                TotP += Val(row("Prima"))
                                                TotM += Val(row("Meta"))
                                            End If
                                        Catch ex As Exception

                                        End Try
                                    Next
                                    If TotP - TotM < 0 Then
                                        e.DisplayText = Format(0.0, "$#,###0.00")
                                    Else
                                        e.DisplayText = Format(TotP - TotM, "$#,###0.00")
                                    End If
                                Case Else
                                    'estos datos no se calculan
                                    e.DisplayText = ""
                            End Select
                        Case Me.MinCustomTotalData + 6      'NETO
                            Select Case e.DataField.FieldName
                                Case "Autos", "Personas", "Danos", "Fianzas", "Total"
                                    Dim list As IList = e.CreateDrillDownDataSource(), TotP As Double = 0, TotM As Double = 0
                                    For i As Integer = 0 To list.Count - 1
                                        Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)
                                        Try
                                            If Grupo = "" Or Grupo = row("Grupo2") Then
                                                TotP += Val(row("Prima"))
                                                TotM += Val(row("Meta"))
                                            End If
                                        Catch ex As Exception

                                        End Try
                                    Next

                                    Dim Excede As Double = 0, Falta As Double = 0
                                    Excede = TotP - TotM
                                    If Excede < 0 Then Excede = 0
                                    Falta = TotM - TotP
                                    If Falta < 0 Then Falta = 0
                                    e.DisplayText = Format(Excede - Falta, "$#,###0.00")

                                Case Else
                                    'estos datos no se calculan
                                    e.DisplayText = ""
                            End Select
                    End Select
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PivotGridControl1.FieldValueDisplayText
        If e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.CustomTotal Then
            If MinCustomTotal = 0 Then MinCustomTotal = e.MinIndex
            Dim prueba As String = ""
            Select Case e.MinIndex
                Case Me.MinCustomTotal
                    e.DisplayText = "TOTAL"
                Case Me.MinCustomTotal + 1
                    e.DisplayText = "PRESUPUESTO"
                Case Me.MinCustomTotal + 2
                    e.DisplayText = "% ALCANZADO"
                Case Me.MinCustomTotal + 3
                    e.DisplayText = "PARTICIPACION"
                Case Me.MinCustomTotal + 4
                    e.DisplayText = "POR CUMPLIR"
                Case Me.MinCustomTotal + 5
                    e.DisplayText = "EXCEDENTE"
                Case Me.MinCustomTotal + 6
                    e.DisplayText = "NETO"
            End Select
        End If
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
            Dim name As String = e.DataField.FieldName
            'Para calcular el cumplimiento
            'la formula (prima / meta) * 100
            Dim TotPrima As Double = 0, TotMeta As Double = 0, TotAnt As Double = 0

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
                    Try
                        TotAnt += Val(row("AnioAnt"))
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
                            e.CustomValue = TotMeta - TotPrima
                            If e.CustomValue < 0 Then e.CustomValue = 0
                            If e.RowField.FieldName = "Anio" Then
                                e.CustomValue = TotDif
                                TotDif = 0
                            Else
                                TotDif += e.CustomValue
                            End If

                        Catch ex As Exception
                            'si no hay meta lo dejamos a cero
                            e.CustomValue = 0
                        End Try

                    Case "Excedente"
                        Try
                            e.CustomValue = TotPrima - TotMeta
                            If e.CustomValue < 0 Then e.CustomValue = 0

                            If e.RowField.FieldName = "Anio" Then
                                e.CustomValue = TotExc
                                TotExc = 0
                            Else
                                TotExc += e.CustomValue
                            End If

                        Catch ex As Exception
                            'si no hay meta lo dejamos a cero
                            e.CustomValue = 0
                        End Try

                    Case "Neto"
                        Try
                            Dim Excede As Double = 0, Falta As Double = 0
                            Excede = TotPrima - TotMeta
                            If Excede < 0 Then Excede = 0

                            Falta = TotMeta - TotPrima
                            If Falta < 0 Then Falta = 0
                            e.CustomValue = Excede - Falta

                        Catch ex As Exception
                            'si no hay meta lo dejamos a cero
                            e.CustomValue = 0
                        End Try

                    Case "Total"
                        e.CustomValue = TotPrima

                    Case "AnioAnt"
                        e.CustomValue = TotAnt

                    Case "Participa"
                        'NECESITAMOS ACTUALIZAR EL FILTRO
                        Call PivotGridControl1_FieldFilterChanged(Nothing, Nothing)
                        Dim GranTotalMeta As Double = Datos.Compute("SUM(Meta)", FiltroGrobal)
                        If GranTotalMeta = 0 Then
                            e.CustomValue = 0
                        Else
                            e.CustomValue = TotMeta / GranTotalMeta
                        End If

                    Case Else
                        e.CustomValue = e.SummaryValue.Summary

                End Select
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Exportar()
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\DatosTec.xls"
            PivotGridControl1.ExportToXls(Archivo, False)
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

    Private Sub PivotGridControl1_FieldFilterChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles PivotGridControl1.FieldFilterChanged
        'iniciamos los contadores para crear correctamente los subtotales personalizados.
        MinCustomTotal = 0 : MinCustomTotalData = 0
        lblFiltro.Text = ""
        Call InicializarFiltro()
        For Each Columna As DevExpress.XtraPivotGrid.PivotGridField In PivotGridControl1.Fields
            'las columnas del area de datos no se usan
            If Columna.FieldName <> "Prima" Then
                If Columna.Area <> DevExpress.XtraPivotGrid.PivotArea.DataArea Or Columna.FieldName = "Anio" Then
                    If Columna.FilterValues.Values.Length > 0 Or Columna.FieldName = "Anio" Then
                        lblFiltro.Text &= Columna.Caption & "="
                        For i As Integer = 0 To Columna.FilterValues.ValuesIncluded.Length - 1
                            lblFiltro.Text &= Columna.FilterValues.ValuesIncluded(i).ToString.Trim & ", "
                            Call ProcesarFiltro(Columna.FieldName, Columna.FilterValues.ValuesIncluded(i).ToString.Trim)
                        Next
                    Else
                        lblFiltro.Text &= Columna.Caption & "=Todos, "
                    End If
                End If
            End If

        Next
        Call FinalizarFiltro()

        lblFiltro.Text = "Para: " & lblFiltro.Text
    End Sub

    Dim FiltroGrobal As String = ""
    Dim FiltroMes As String = "", FiltroRamo As String = "", FiltroCia As String = "", FiltroGC As String = "", FiltroTA As String = "", FiltroGR As String = ""

    Private Sub InicializarFiltro()
        FiltroMes = "" : FiltroRamo = "" : FiltroCia = "" : FiltroGC = "" : FiltroTA = "" : FiltroGR = ""
    End Sub

    Private Sub ProcesarFiltro(ByVal Campo As String, ByVal Valor As String)
        Select Case Campo
            Case "Mes"
                If FiltroMes = "" Then
                    FiltroMes = "'" & Valor & "'"
                Else
                    FiltroMes &= ", '" & Valor & "'"
                End If
            Case "Ramo"
                If FiltroRamo = "" Then
                    FiltroRamo = "'" & Valor & "'"
                Else
                    FiltroRamo &= ", '" & Valor & "'"
                End If
            Case "Cia"
                If FiltroCia = "" Then
                    FiltroCia = "'" & Valor & "'"
                Else
                    FiltroCia &= ", '" & Valor & "'"
                End If
            Case "Grupo"
                If FiltroGC = "" Then
                    FiltroGC = "'" & Valor & "'"
                Else
                    FiltroGC &= ", '" & Valor & "'"
                End If
            Case "TipoAnexo"
                If FiltroTA = "" Then
                    FiltroTA = "'" & Valor & "'"
                Else
                    FiltroTA &= ", '" & Valor & "'"
                End If
            Case "Grupo2"
                If FiltroGR = "" Then
                    FiltroGR = "'" & Valor & "'"
                Else
                    FiltroGR &= ", '" & Valor & "'"
                End If
        End Select
    End Sub

    Private Sub FinalizarFiltro()
        FiltroGrobal = ""
        If FiltroMes <> "" Then
            FiltroMes = " MES IN (" & FiltroMes & ")"
            If FiltroGrobal = "" Then
                FiltroGrobal &= FiltroMes
            Else
                FiltroGrobal &= " and " & FiltroMes
            End If
        End If
        If FiltroRamo <> "" Then
            FiltroRamo = " RAMO IN (" & FiltroRamo & ")"
            If FiltroGrobal = "" Then
                FiltroGrobal &= FiltroRamo
            Else
                FiltroGrobal &= " and " & FiltroRamo
            End If
        End If
        If FiltroCia <> "" Then
            FiltroCia = " CIA IN (" & FiltroCia & ")"
            If FiltroGrobal = "" Then
                FiltroGrobal &= FiltroCia
            Else
                FiltroGrobal &= " and " & FiltroCia
            End If
        End If
        If FiltroGC <> "" Then
            FiltroGC = " GRUPO IN (" & FiltroGC & ")"
            If FiltroGrobal = "" Then
                FiltroGrobal &= FiltroGC
            Else
                FiltroGrobal &= " and " & FiltroGC
            End If
        End If
        If FiltroTA <> "" Then
            FiltroTA = " TipoAnexo IN (" & FiltroTA & ")"
            If FiltroGrobal = "" Then
                FiltroGrobal &= FiltroTA
            Else
                FiltroGrobal &= " and " & FiltroTA
            End If
        End If
        If FiltroGR <> "" Then
            FiltroGR = " Grupo2 IN (" & FiltroGR & ")"
            If FiltroGrobal = "" Then
                FiltroGrobal &= FiltroGR
            Else
                FiltroGrobal &= " and " & FiltroGR
            End If
        End If
    End Sub

End Class