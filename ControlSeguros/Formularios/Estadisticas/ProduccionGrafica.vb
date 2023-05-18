Imports Utilerias.Genericas
Imports DevExpress.XtraCharts

Public Class ProduccionGrafica

    Private AnioBase As Integer, MesBase As String
    Dim Ds As New DataSet, strSQL As String = ""

    Private Sub ProduccionGrafica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GenerarDatos()
    End Sub

    Public Sub ActualizarDatos()
        Call GenerarDatos()
    End Sub

    Private Sub GenerarDatos()
        Me.Cursor = Cursors.WaitCursor
        Try
            AnioBase = AnioAnalisis
            MesBase = StiGlobalConn.ObtenerDataset("select max(month(FechaMovimiento)) from FacturasMovimientos where year(FechaMovimiento) = " & AnioBase).Tables(0).Rows(0).Item(0)
            MesBase = StiGlobalConn.ObtenerDataset("select NombreMes from Meses where IdMes = " & MesBase).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            AnioBase = Date.Today.Year
            MesBase = ""
        End Try

        Dim ColumnaPrima As String = ""
        Dim ColumnaPrima2 As String = ""
        ColumnaPrima = " ISNULL(A.Prima,0.0)  "
        ColumnaPrima2 = " ISNULL(B.Prima,0.0)  "

        Try
            ''prima año actual
            strSQL = "  Select 'ACT' as Id"
            strSQL &= " ,year(m.FechaMovimiento) as Anio"
            strSQL &= " ,month(m.FechaMovimiento) as Mes"
            strSQL &= " ,s.Abreviado as NombreMes "
            strSQL &= " , sum(m.PrimaNeta) as Prima"
            strSQL &= " , 0.0 as Siniestros "
            strSQL &= " , 0.0 as Meta "
            strSQL &= " , 0.0 as AnioAnt "
            strSQL &= " from FacturasMovimientos as m "
            strSQL &= " inner join Meses as s on month(FechaMovimiento) = s.IdMes "
            strSQL &= " where m.TipoMovimiento in ('EMISION','ANULACION') "
            strSQL &= " and year(m.FechaMovimiento) = " & AnioBase
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as p where p.idpoliza = m.idpoliza and p.idproducto = m.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by year(m.FechaMovimiento), month(m.FechaMovimiento), s.Abreviado"

            strSQL &= " union "

            ''prima año anterior
            strSQL &= "  Select 'ANT' as Id"
            strSQL &= " ,year(m.FechaMovimiento) as Anio"
            strSQL &= " ,month(m.FechaMovimiento) as Mes"
            strSQL &= " ,s.Abreviado as NombreMes "
            strSQL &= " , 0.0 as Prima"
            strSQL &= " , 0.0 as Siniestros "
            strSQL &= " , 0.0 as Meta "
            strSQL &= " , sum(m.PrimaNeta) as AnioAnt "
            strSQL &= " from FacturasMovimientos as m "
            strSQL &= " inner join Meses as s on month(FechaMovimiento) = s.IdMes "
            strSQL &= " where m.TipoMovimiento in ('EMISION','ANULACION') "
            strSQL &= " and year(m.FechaMovimiento) = " & (AnioBase - 1)
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as p where p.idpoliza = m.idpoliza and p.idproducto = m.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by year(m.FechaMovimiento), month(m.FechaMovimiento), s.Abreviado"

            strSQL &= " union "

            ''siniestros año actual
            strSQL &= "  Select 'SIN' as Id"
            strSQL &= " ,year(si.FechaPago) as Anio"
            strSQL &= " ,month(si.FechaPago) as Mes"
            strSQL &= " ,s.Abreviado as NombreMes "
            strSQL &= " , 0.0 as Prima"
            strSQL &= " , sum(si.ValorReembolso) as Siniestros "
            strSQL &= " , 0.0 as Meta "
            strSQL &= " , 0.0 as AnioAnt "
            strSQL &= " from SiniestrosPagos as si "
            strSQL &= " inner join Meses as s on month(si.FechaPago) = s.IdMes "
            strSQL &= " where year(si.FechaPago) = " & AnioBase
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as p where p.idpoliza = si.idpoliza and p.idproducto = si.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by year(si.FechaPago), month(si.FechaPago), s.Abreviado"

            strSQL &= " union "

            '' metas
            strSQL &= "  Select 'MET' as Id"
            strSQL &= " , mt.Anio as Anio"
            strSQL &= " , mt.Mes as Mes"
            strSQL &= " , s.Abreviado as NombreMes "
            strSQL &= " , 0.0 as Prima"
            strSQL &= " , 0.0 as Siniestros "
            strSQL &= " , sum(mt.Primas) as Meta "
            strSQL &= " , 0.0 as AnioAnt "
            strSQL &= " from Metas as mt "
            strSQL &= " inner join Meses as s on mt.Mes = s.IdMes "
            strSQL &= " where mt.Anio = " & AnioBase
            strSQL &= " group by mt.Anio, mt.Mes, s.Abreviado"

            strSQL &= " order by 2"


            Application.DoEvents()
            Ds = StiGlobalConn.ObtenerDataset(strSQL)
        Catch ex As Exception

        End Try

        Call GenerarGraficaPrimaSinMensual()
        Call GenerarGraficaPrimaSinAcumulado()
        Call GenerarGraficaPrimasMetasMensual()
        Call GenerarGraficaPrimasMetasAcumulado()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GenerarGraficaPrimaSinMensual()
        Try
            'PRIMERA GRAFICA chrPriSinMensual PrimaS CONTRO Siniestros MENSUALES
            chrPriSinMensual.Series.Clear()   'limpiamos las series
            chrPriSinMensual.Titles.Clear()   'borramos todos los titulos
            'lblGrafico1.Text = "Primas Vrs. Siniestros Mensuales al Mes de " & cboMeses.SelectedItem.Text
            Dim Serie1 As New Series() : Dim Serie2 As New Series()

            Serie1.Label.Visible = False      'Muestra los valores
            Serie1.ArgumentScaleType = ScaleType.Numerical
            Serie1.View = New LineSeriesView
            Serie1.DataSource = Ds.Tables(0).Copy
            'Serie1.DataFilters.Add(New DataFilter("Mes", "System.Int32", DataFilterCondition.LessThanOrEqual, CInt(2)))
            Serie1.ArgumentScaleType = ScaleType.Qualitative
            Serie1.ArgumentDataMember = "NombreMes"
            Serie1.ValueScaleType = ScaleType.Numerical
            Serie1.ValueDataMembers(0) = "Prima"
            Serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie1.ShowInLegend = True
            Serie1.LegendText = "Prima"
            Serie1.Label.OverlappingOptions.ResolveOverlapping = True
            Serie1.Label.OverlappingOptions.Indent = 10

            Serie2.Label.Visible = False
            Serie2.ArgumentScaleType = ScaleType.Numerical
            Serie2.View = New LineSeriesView
            Serie2.DataSource = Ds.Tables(0).Copy
            'Serie2.DataFilters.Add(New DataFilter("Mes", "System.Int32", DataFilterCondition.LessThanOrEqual, CInt(2)))
            Serie2.ArgumentScaleType = ScaleType.Qualitative
            Serie2.ArgumentDataMember = "NombreMes"
            Serie2.ValueScaleType = ScaleType.Numerical
            Serie2.ValueDataMembers(0) = "Siniestros"
            Serie2.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie2.ShowInLegend = True
            Serie2.LegendText = "Siniestros"
            Serie2.Label.OverlappingOptions.ResolveOverlapping = True
            Serie2.Label.OverlappingOptions.Indent = 10

            chrPriSinMensual.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrPriSinMensual.Legend.Visible = True
            chrPriSinMensual.SeriesTemplate.Label.Visible = True
            chrPriSinMensual.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrPriSinMensual.SeriesTemplate.ShowInLegend = True
            chrPriSinMensual.Series.Add(Serie1)
            chrPriSinMensual.Series.Add(Serie2)


            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            ChartTitle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ChartTitle1.Text = "Primas y Siniestros Mensuales a " & MesBase.Trim & "/" & AnioBase
            ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
            chrPriSinMensual.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GenerarGraficaPrimaSinAcumulado()
        'chrPriSinAcumulado
        'este cuadro muestra el acumulado del año
        'Cargamos el Consolidado de Primas y Siniestros *************************************************************
        'Para ello calculamos el total acumulado de Primas y Siniestros
        Try
            Dim PrimasAcum As Double = 0, SiniestrosAcum As Double = 0
            Try
                PrimasAcum = Ds.Tables(0).Compute("sum(Prima)", "")
            Catch ex As Exception
                PrimasAcum = 0
            End Try
            Try
                SiniestrosAcum = Ds.Tables(0).Compute("sum(Siniestros)", "")
            Catch ex As Exception
                SiniestrosAcum = 0
            End Try

            chrPriSinAcumulado.Series.Clear()   'limpiamos las series
            chrPriSinAcumulado.Titles.Clear()   'borramos todos los titulos
            'lblGrafico2.Text = "Primas Vrs. Siniestros Acumulados al Mes de " & cboMeses.SelectedItem.Text
            Dim Serie1 As New Series() : Dim Serie2 As New Series()

            Serie1.Label.Visible = True     'muestra los valores de la barra
            Serie1.ArgumentScaleType = ScaleType.Numerical
            Serie1.View = New SideBySideBarSeriesView
            Serie1.ArgumentScaleType = ScaleType.Qualitative
            Serie1.ValueScaleType = ScaleType.Numerical
            Serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie1.ShowInLegend = True
            Serie1.LegendText = "PrimaS " & AnioBase
            Serie1.Points.Add(New DevExpress.XtraCharts.SeriesPoint("ACUMULADO", PrimasAcum))

            Serie2.Label.Visible = True
            Serie2.ArgumentScaleType = ScaleType.Numerical
            Serie2.View = New SideBySideBarSeriesView
            Serie2.ArgumentScaleType = ScaleType.Qualitative
            Serie2.ValueScaleType = ScaleType.Numerical
            Serie2.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie2.ShowInLegend = True
            Serie2.LegendText = "Siniestros " & AnioBase
            Serie2.Points.Add(New DevExpress.XtraCharts.SeriesPoint("ACUMULADO", SiniestrosAcum))

            chrPriSinAcumulado.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrPriSinAcumulado.Legend.Visible = True
            chrPriSinAcumulado.SeriesTemplate.Label.Visible = True
            chrPriSinAcumulado.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrPriSinAcumulado.SeriesTemplate.ShowInLegend = True
            chrPriSinAcumulado.Series.Add(Serie1)
            chrPriSinAcumulado.Series.Add(Serie2)

            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            ChartTitle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ChartTitle1.Text = "Primas y Siniestros Acumulados a " & MesBase.Trim & "/" & AnioBase
            ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.chrPriSinAcumulado.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GenerarGraficaPrimasMetasMensual()
        'chrPriMetaMensual
        'este cuadro genera un comparativo mensual de Primas, Metas y Primas año anterior
        'PRIMERA GRAFICA chrPriSinMensual PrimaS CONTRO Siniestros MENSUALES
        Try
            chrPriMetaMensual.Series.Clear()   'limpiamos las series
            chrPriMetaMensual.Titles.Clear()   'borramos todos los titulos
            'lblGrafico1.Text = "Primas Vrs. Siniestros Mensuales al Mes de " & cboMeses.SelectedItem.Text
            Dim Serie1 As New Series() : Dim Serie2 As New Series() : Dim Serie3 As New Series()

            Serie1.Label.Visible = False      'Muestra los valores
            Serie1.ArgumentScaleType = ScaleType.Numerical
            Serie1.View = New SideBySideBarSeriesView
            Serie1.DataSource = Ds.Tables(0).Copy
            Serie1.ArgumentScaleType = ScaleType.Qualitative
            Serie1.ArgumentDataMember = "NombreMes"
            Serie1.ValueScaleType = ScaleType.Numerical
            Serie1.ValueDataMembers(0) = "Meta"
            Serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie1.ShowInLegend = True
            Serie1.LegendText = "Meta " & AnioBase
            Serie1.Label.OverlappingOptions.ResolveOverlapping = True
            Serie1.Label.OverlappingOptions.Indent = 10

            Serie2.Label.Visible = False
            Serie2.ArgumentScaleType = ScaleType.Numerical
            Serie2.View = New SideBySideBarSeriesView
            Serie2.DataSource = Ds.Tables(0).Copy
            Serie2.ArgumentScaleType = ScaleType.Qualitative
            Serie2.ArgumentDataMember = "NombreMes"
            Serie2.ValueScaleType = ScaleType.Numerical
            Serie2.ValueDataMembers(0) = "Prima"
            Serie2.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie2.ShowInLegend = True
            Serie2.LegendText = "Prima " & AnioBase
            Serie2.Label.OverlappingOptions.ResolveOverlapping = True
            Serie2.Label.OverlappingOptions.Indent = 10

            Serie3.Label.Visible = False
            Serie3.ArgumentScaleType = ScaleType.Numerical
            Serie3.View = New SideBySideBarSeriesView
            Serie3.DataSource = Ds.Tables(0).Copy
            Serie3.ArgumentScaleType = ScaleType.Qualitative
            Serie3.ArgumentDataMember = "NombreMes"
            Serie3.ValueScaleType = ScaleType.Numerical
            Serie3.ValueDataMembers(0) = "AnioAnt"
            Serie3.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie3.ShowInLegend = True
            Serie3.LegendText = "Prima " & AnioBase - 1
            Serie3.Label.OverlappingOptions.ResolveOverlapping = True
            Serie3.Label.OverlappingOptions.Indent = 10


            chrPriMetaMensual.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrPriMetaMensual.Legend.Visible = True
            chrPriMetaMensual.SeriesTemplate.Label.Visible = True
            chrPriMetaMensual.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrPriMetaMensual.SeriesTemplate.ShowInLegend = True
            chrPriMetaMensual.Series.Add(Serie1)
            chrPriMetaMensual.Series.Add(Serie2)
            chrPriMetaMensual.Series.Add(Serie3)

            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            ChartTitle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ChartTitle1.Text = "Presupuesto Vs. Producción Vs. Producción Año Anterior Mensuales a " & MesBase.Trim & "/" & AnioBase
            ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
            chrPriMetaMensual.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GenerarGraficaPrimasMetasAcumulado()
        'chrPriMetaAcumulado

        'este cuadro muestra el acumulado del año
        'Cargamos el Consolidado de Primas y Metas y año anterior *************************************************************
        'Para ello calculamos el total acumulado de Primas y Siniestros


        Try
            Dim PrimasAcum As Double = 0, MetasAcum As Double = 0, PrimasAntAcum As Double = 0
            Try
                PrimasAcum = Ds.Tables(0).Compute("sum(Prima)", "")
            Catch ex As Exception
                PrimasAcum = 0
            End Try
            Try
                MetasAcum = Ds.Tables(0).Compute("sum(Meta)", "")
            Catch ex As Exception
                MetasAcum = 0
            End Try

            Try
                PrimasAntAcum = Ds.Tables(0).Compute("sum(AnioAnt)", "")
            Catch ex As Exception
                PrimasAntAcum = 0
            End Try


            chrPriMetaAcumulado.Series.Clear()   'limpiamos las series
            chrPriMetaAcumulado.Titles.Clear()   'borramos todos los titulos
            Dim Serie1 As New Series() : Dim Serie2 As New Series(), Serie3 As New Series()

            Serie1.Label.Visible = True     'muestra los valores de la barra
            Serie1.ArgumentScaleType = ScaleType.Numerical
            Serie1.View = New SideBySideBarSeriesView
            Serie1.ArgumentScaleType = ScaleType.Qualitative
            Serie1.ValueScaleType = ScaleType.Numerical
            Serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie1.ShowInLegend = True
            Serie1.LegendText = "Meta " & AnioBase
            Serie1.Points.Add(New DevExpress.XtraCharts.SeriesPoint("ACUMULADO", MetasAcum))

            Serie2.Label.Visible = True
            Serie2.ArgumentScaleType = ScaleType.Numerical
            Serie2.View = New SideBySideBarSeriesView
            Serie2.ArgumentScaleType = ScaleType.Qualitative
            Serie2.ValueScaleType = ScaleType.Numerical
            Serie2.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie2.ShowInLegend = True
            Serie2.LegendText = "Prima " & AnioBase
            Serie2.Points.Add(New DevExpress.XtraCharts.SeriesPoint("ACUMULADO", PrimasAcum))

            Serie3.Label.Visible = True
            Serie3.ArgumentScaleType = ScaleType.Numerical
            Serie3.View = New SideBySideBarSeriesView
            Serie3.ArgumentScaleType = ScaleType.Qualitative
            Serie3.ValueScaleType = ScaleType.Numerical
            Serie3.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie3.ShowInLegend = True
            Serie3.LegendText = "Prima " & AnioBase - 1
            Serie3.Points.Add(New DevExpress.XtraCharts.SeriesPoint("ACUMULADO", PrimasAntAcum))

            chrPriMetaAcumulado.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrPriMetaAcumulado.Legend.Visible = True
            chrPriMetaAcumulado.SeriesTemplate.Label.Visible = True
            chrPriMetaAcumulado.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrPriMetaAcumulado.SeriesTemplate.ShowInLegend = True
            chrPriMetaAcumulado.Series.Add(Serie1)
            chrPriMetaAcumulado.Series.Add(Serie2)
            chrPriMetaAcumulado.Series.Add(Serie3)

            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            ChartTitle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ChartTitle1.Text = "Presupuesto Vs. Producción Vs. Producción Año Anterior Acumulados a " & MesBase.Trim & "/" & AnioBase
            ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.chrPriMetaAcumulado.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chrPriSinMensual_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chrPriSinMensual.ObjectHotTracked
        Try
            Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
            Dim s As String
            If Not point Is Nothing Then
                'para sacar los datos completos de la fila
                'Dim rowView As DataRowView = CType(point.Tag, DataRowView)
                'Dim s As String = Format(Val(rowView("Prima")), "$#,###0.00")
                s = Format(Val(point.ValuesSerializable), "$#,###0.00")
                ToolTipController1.ShowHint(s)
            Else
                ToolTipController1.HideHint()
            End If
        Catch ex As Exception
            'no controlaremos el error
        End Try
    End Sub

    Private Sub chrPriMetaMensual_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chrPriMetaMensual.ObjectHotTracked
        Try
            Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
            Dim s As String
            If Not point Is Nothing Then
                'para sacar los datos completos de la fila
                'Dim rowView As DataRowView = CType(point.Tag, DataRowView)
                'Dim s As String = Format(Val(rowView("Prima")), "$#,###0.00")
                s = Format(Val(point.ValuesSerializable), "$#,###0.00")
                ToolTipController1.ShowHint(s)
            Else
                ToolTipController1.HideHint()
            End If
        Catch ex As Exception
            'no controlaremos el error
        End Try
    End Sub

    Public Sub Exportar()
        Try
            Dim RutaBase As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos)

            chrPriSinMensual.ExportToImage(RutaBase & "\graEst1.png", System.Drawing.Imaging.ImageFormat.Png)
            chrPriSinAcumulado.ExportToImage(RutaBase & "\graEst2.png", System.Drawing.Imaging.ImageFormat.Png)
            chrPriMetaMensual.ExportToImage(RutaBase & "\graEst3.png", System.Drawing.Imaging.ImageFormat.Png)
            chrPriMetaAcumulado.ExportToImage(RutaBase & "\graEst4.png", System.Drawing.Imaging.ImageFormat.Png)

            Dim Miexcel As Object, Hoja As Object
            Miexcel = CreateObject("Excel.Application")
            Miexcel.SheetsInNewWorkbook = 1
            Miexcel.Workbooks.Add()
            Hoja = Miexcel.Worksheets(1)

            Dim pic As Object
            pic = Hoja.Pictures.Insert(RutaBase & "\graEst1.png")
            pic.Top = Hoja.Range("A2").Top
            pic.Left = Hoja.Range("A2").Left + 5

            Dim pic2 As Object
            pic2 = Hoja.Pictures.Insert(RutaBase & "\graEst2.png")
            pic2.Top = pic.Top
            pic2.Left = pic.Left + pic.Width + 5

            Dim pic3 As Object
            pic3 = Hoja.Pictures.Insert(RutaBase & "\graEst3.png")
            pic3.Top = pic.Top + pic.Height + 5
            pic3.Left = pic.Left

            Dim pic4 As Object
            pic4 = Hoja.Pictures.Insert(RutaBase & "\graEst4.png")
            pic4.Top = pic2.Top + pic2.Height + 5
            pic4.Left = pic3.Left + pic3.Width + 5

            Miexcel.Visible = True
            Hoja = Nothing
            Miexcel = Nothing

        Catch ex As Exception
            MsgBox("No se puede exportar los datos, verifique que no tienen abierto un cuadro de excel del mismo reporte")
        End Try
    End Sub

End Class