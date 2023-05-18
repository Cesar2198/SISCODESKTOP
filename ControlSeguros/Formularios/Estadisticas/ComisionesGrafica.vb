
Imports Utilerias.Genericas
Imports DevExpress.XtraCharts

Public Class ComisionGrafica

    Private AnioBase As Integer, MesBase As String
    Dim DsAseg As New DataSet, DsRamo As New DataSet, strSQL As String = ""
    Dim DsAsegY As New DataSet, DsRamoY As New DataSet

    Private Sub ComisionGrafica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GenerarDatos()
    End Sub

    Public Sub ActualizarDatos()
        Call GenerarDatos()
    End Sub

    Private Sub GenerarDatos()
        Me.Cursor = Cursors.WaitCursor
        Try
            AnioBase = AnioAnalisis
            MesBase = StiGlobalConn.ObtenerDataset("select max(month(FechaMovimiento)) from FacturasMovimientos where TipoMovimiento = 'PAGO' and year(FechaMovimiento) = " & AnioBase).Tables(0).Rows(0).Item(0)
            MesBase = StiGlobalConn.ObtenerDataset("select NombreMes from Meses where IdMes = " & MesBase).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            AnioBase = Date.Today.Year
            MesBase = ""
        End Try

        Try

            strSQL = "  Select "
            strSQL &= " a.Siglas as Aseguradora"
            strSQL &= " , sum(m.comision * -1) as Comision"
            strSQL &= " , 0.0 as AnioAnt "
            strSQL &= " from FacturasMovimientos as m "
            strSQL &= " inner join Meses as s on month(FechaMovimiento) = s.IdMes "
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto"
            strSQL &= " inner join Aseguradoras as a on p.idaseguradora = a.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = m.idramo"
            strSQL &= " where m.TipoMovimiento in ('PAGO') "
            strSQL &= " and year(m.FechaMovimiento) = " & AnioBase
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by a.Siglas"

            Application.DoEvents()
            DsAsegY = StiGlobalConn.ObtenerDataset(strSQL)

            strSQL = "  Select "
            strSQL &= " a.Siglas as Aseguradora"
            strSQL &= " , sum(m.comision * -1) as Comision"
            strSQL &= " , 0.0 as AnioAnt "
            strSQL &= " from FacturasMovimientos as m "
            strSQL &= " inner join Meses as s on month(FechaMovimiento) = s.IdMes "
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto"
            strSQL &= " inner join Aseguradoras as a on p.idaseguradora = a.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = m.idramo"
            strSQL &= " where m.TipoMovimiento in ('PAGO') "
            strSQL &= " and year(m.FechaMovimiento) = " & AnioBase
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by a.Siglas"

            strSQL &= " union "

            strSQL &= "  Select "
            strSQL &= " a.Siglas as Aseguradora"
            strSQL &= " ,0.0  as Comision"
            strSQL &= " ,sum(m.comision * -1) as AnioAnt "
            strSQL &= " from FacturasMovimientos as m "
            strSQL &= " inner join Meses as s on month(FechaMovimiento) = s.IdMes "
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto"
            strSQL &= " inner join Aseguradoras as a on p.idaseguradora = a.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = m.idramo"
            strSQL &= " where m.TipoMovimiento in ('PAGO') "
            strSQL &= " and year(m.FechaMovimiento) = " & AnioBase - 1
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            strSQL &= " group by a.Siglas"

            Application.DoEvents()
            DsAseg = StiGlobalConn.ObtenerDataset(strSQL)

            strSQL = "  Select "
            strSQL &= " r.NombreRamo as Ramo"
            strSQL &= " , sum(m.comision * -1) as Comision"
            strSQL &= " , 0.0 as AnioAnt "
            strSQL &= " from FacturasMovimientos as m "
            strSQL &= " inner join Meses as s on month(FechaMovimiento) = s.IdMes "
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto"
            strSQL &= " inner join Aseguradoras as a on p.idaseguradora = a.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = m.idramo"
            strSQL &= " where m.TipoMovimiento in ('PAGO') "
            strSQL &= " and year(m.FechaMovimiento) = " & AnioBase
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by r.NombreRamo"
            Application.DoEvents()
            DsRamoY = StiGlobalConn.ObtenerDataset(strSQL)

            strSQL = "  Select "
            strSQL &= " r.NombreRamo as Ramo"
            strSQL &= " , sum(m.comision * -1) as Comision"
            strSQL &= " , 0.0 as AnioAnt "
            strSQL &= " from FacturasMovimientos as m "
            strSQL &= " inner join Meses as s on month(FechaMovimiento) = s.IdMes "
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto"
            strSQL &= " inner join Aseguradoras as a on p.idaseguradora = a.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = m.idramo"
            strSQL &= " where m.TipoMovimiento in ('PAGO') "
            strSQL &= " and year(m.FechaMovimiento) = " & AnioBase
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by r.NombreRamo"

            strSQL &= " union "

            strSQL &= "  Select "
            strSQL &= " r.NombreRamo as Ramo"
            strSQL &= " ,0.0  as Comision"
            strSQL &= " ,sum(m.comision * -1) as AnioAnt "
            strSQL &= " from FacturasMovimientos as m "
            strSQL &= " inner join Meses as s on month(FechaMovimiento) = s.IdMes "
            strSQL &= " inner join Productos as p on p.idproducto = m.idproducto"
            strSQL &= " inner join Aseguradoras as a on p.idaseguradora = a.idaseguradora"
            strSQL &= " inner join RamoSeguros as r on r.idramo = m.idramo"
            strSQL &= " where m.TipoMovimiento in ('PAGO') "
            strSQL &= " and year(m.FechaMovimiento) = " & AnioBase - 1
            If VisibilidadUsuario() = "D" Then
                strSQL &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            strSQL &= " group by r.NombreRamo"

            Application.DoEvents()
            DsRamo = StiGlobalConn.ObtenerDataset(strSQL)

        Catch ex As Exception
            msgError(ex)
        End Try

        Call GenerarGraficaComiPastelAseguradora()
        Call GenerarGraficaComiPastelRamo()
        Call GenerarGraficaComiAsegAnio()
        Call GenerarGraficaComiRamoAnio()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GenerarGraficaComiPastelAseguradora()
        Try
            'PRIMERA GRAFICA COMISIONES POR ASEGURADORA
            chrComiAseg.Series.Clear()   'limpiamos las series
            chrComiAseg.Titles.Clear()   'borramos todos los titulos
            Dim Serie1 As New Series()

            Serie1.Label.Visible = True
            Serie1.ArgumentScaleType = ScaleType.Numerical
            Serie1.View = New Pie3DSeriesView
            Serie1.DataSource = DsAsegY.Tables(0).Copy
            Serie1.ArgumentScaleType = ScaleType.Qualitative
            Serie1.ArgumentDataMember = "Aseguradora"
            Serie1.ValueScaleType = ScaleType.Numerical
            Serie1.ValueDataMembers(0) = "Comision"
            Serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            Serie1.ShowInLegend = True
            Serie1.LegendText = "Comisión"
            Serie1.PointOptions.PointView = PointView.Values
            Serie1.LegendPointOptions.PointView = PointView.ArgumentAndValues

            chrComiAseg.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrComiAseg.Legend.Visible = True
            chrComiAseg.SeriesTemplate.Label.Visible = True
            chrComiAseg.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrComiAseg.SeriesTemplate.ShowInLegend = True
            chrComiAseg.Series.Add(Serie1)
            CType(chrComiAseg.Diagram, Diagram3D).RuntimeRotation = True

            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            ChartTitle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ChartTitle1.Text = "Comisiones por Aseguradora a " & MesBase.Trim & "/" & AnioBase
            ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
            chrComiAseg.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub GenerarGraficaComiPastelRamo()
        Try
            'PRIMERA GRAFICA COMISIONES POR RAMO
            chrComiRamo.Series.Clear()   'limpiamos las series
            chrComiRamo.Titles.Clear()   'borramos todos los titulos
            Dim Serie1 As New Series()

            Serie1.Label.Visible = True
            Serie1.ArgumentScaleType = ScaleType.Numerical
            Serie1.View = New Pie3DSeriesView
            Serie1.DataSource = DsRamoY.Tables(0).Copy
            Serie1.ArgumentScaleType = ScaleType.Qualitative
            Serie1.ArgumentDataMember = "Ramo"
            Serie1.ValueScaleType = ScaleType.Numerical
            Serie1.ValueDataMembers(0) = "Comision"
            Serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            Serie1.ShowInLegend = True
            Serie1.LegendText = "Comisión"
            Serie1.PointOptions.PointView = PointView.Values
            Serie1.LegendPointOptions.PointView = PointView.ArgumentAndValues

            Serie1.SeriesPointsSorting = SortingMode.Ascending
            Serie1.SeriesPointsSortingKey = SeriesPointKey.Value_1

            chrComiRamo.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrComiRamo.Legend.Visible = True
            chrComiRamo.SeriesTemplate.Label.Visible = True
            chrComiRamo.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrComiRamo.SeriesTemplate.ShowInLegend = True
            chrComiRamo.Series.Add(Serie1)
            CType(chrComiRamo.Diagram, Diagram3D).RuntimeRotation = True

            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            ChartTitle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ChartTitle1.Text = "Comisiones por Ramo a " & MesBase.Trim & "/" & AnioBase
            ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
            chrComiRamo.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub GenerarGraficaComiAsegAnio()
        Try
            chrComiAsegAnio.Series.Clear()   'limpiamos las series
            chrComiAsegAnio.Titles.Clear()   'borramos todos los titulos

            Dim Serie1 As New Series() : Dim Serie2 As New Series()

            Serie1.Label.Visible = False      'Muestra los valores
            Serie1.ArgumentScaleType = ScaleType.Numerical
            Serie1.View = New SideBySideBarSeriesView
            Serie1.DataSource = DsAseg.Tables(0).Copy
            Serie1.ArgumentScaleType = ScaleType.Qualitative
            Serie1.ArgumentDataMember = "Aseguradora"
            Serie1.ValueScaleType = ScaleType.Numerical
            Serie1.ValueDataMembers(0) = "AnioAnt"
            Serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie1.ShowInLegend = True
            Serie1.LegendText = "Comisión " & AnioBase - 1
            'Serie1.Label.OverlappingOptions.ResolveOverlapping = True
            'Serie1.Label.OverlappingOptions.Indent = 10

            Serie2.Label.Visible = False
            Serie2.ArgumentScaleType = ScaleType.Numerical
            Serie2.View = New SideBySideBarSeriesView
            Serie2.DataSource = DsAseg.Tables(0).Copy
            Serie2.ArgumentScaleType = ScaleType.Qualitative
            Serie2.ArgumentDataMember = "Aseguradora"
            Serie2.ValueScaleType = ScaleType.Numerical
            Serie2.ValueDataMembers(0) = "Comision"
            Serie2.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie2.ShowInLegend = True
            Serie2.LegendText = "Comisión " & AnioBase
            'Serie2.Label.OverlappingOptions.ResolveOverlapping = True
            'Serie2.Label.OverlappingOptions.Indent = 10

            
            chrComiAsegAnio.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrComiAsegAnio.Legend.Visible = True
            chrComiAsegAnio.SeriesTemplate.Label.Visible = True
            chrComiAsegAnio.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrComiAsegAnio.SeriesTemplate.ShowInLegend = True
            chrComiAsegAnio.Series.Add(Serie1)
            chrComiAsegAnio.Series.Add(Serie2)

            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            ChartTitle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ChartTitle1.Text = "Comisiones por Aseguradora Año Actual y Anterior " & MesBase.Trim & "/" & AnioBase
            ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
            chrComiAsegAnio.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GenerarGraficaComiRamoAnio()
        Try
            chrComiRamoAnio.Series.Clear()   'limpiamos las series
            chrComiRamoAnio.Titles.Clear()   'borramos todos los titulos

            Dim Serie1 As New Series() : Dim Serie2 As New Series()

            Serie1.Label.Visible = False      'Muestra los valores
            Serie1.ArgumentScaleType = ScaleType.Numerical
            Serie1.View = New SideBySideBarSeriesView
            Serie1.DataSource = DsRamo.Tables(0).Copy
            Serie1.ArgumentScaleType = ScaleType.Qualitative
            Serie1.ArgumentDataMember = "Ramo"
            Serie1.ValueScaleType = ScaleType.Numerical
            Serie1.ValueDataMembers(0) = "AnioAnt"
            Serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie1.ShowInLegend = True
            Serie1.LegendText = "Comisión " & AnioBase - 1
            'Serie1.Label.OverlappingOptions.ResolveOverlapping = True
            'Serie1.Label.OverlappingOptions.Indent = 10

            Serie2.Label.Visible = False
            Serie2.ArgumentScaleType = ScaleType.Numerical
            Serie2.View = New SideBySideBarSeriesView
            Serie2.DataSource = DsRamo.Tables(0).Copy
            Serie2.ArgumentScaleType = ScaleType.Qualitative
            Serie2.ArgumentDataMember = "Ramo"
            Serie2.ValueScaleType = ScaleType.Numerical
            Serie2.ValueDataMembers(0) = "Comision"
            Serie2.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
            Serie2.ShowInLegend = True
            Serie2.LegendText = "Comisión " & AnioBase
            'Serie2.Label.OverlappingOptions.ResolveOverlapping = True
            'Serie2.Label.OverlappingOptions.Indent = 10


            chrComiRamoAnio.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrComiRamoAnio.Legend.Visible = True
            chrComiRamoAnio.SeriesTemplate.Label.Visible = True
            chrComiRamoAnio.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chrComiRamoAnio.SeriesTemplate.ShowInLegend = True
            chrComiRamoAnio.Series.Add(Serie1)
            chrComiRamoAnio.Series.Add(Serie2)

            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            ChartTitle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ChartTitle1.Text = "Comisiones por Ramo Año Actual y Anterior " & MesBase.Trim & "/" & AnioBase
            ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
            chrComiRamoAnio.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})


        Catch ex As Exception

        End Try
    End Sub

    'Private Sub chrComiAseg_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chrComiAseg.ObjectHotTracked
    '    Try
    '        Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
    '        Dim s As String
    '        If Not point Is Nothing Then
    '            'para sacar los datos completos de la fila
    '            'Dim rowView As DataRowView = CType(point.Tag, DataRowView)
    '            'Dim s As String = Format(Val(rowView("Prima")), "$#,###0.00")
    '            s = Format(Val(point.ValuesSerializable), "$#,###0.00")
    '            ToolTipController1.ShowHint(s)
    '        Else
    '            ToolTipController1.HideHint()
    '        End If
    '    Catch ex As Exception
    '        'no controlaremos el error
    '    End Try
    'End Sub

    Private Sub chrComiAsegAnio_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chrComiAsegAnio.ObjectHotTracked
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

            chrComiAseg.ExportToImage(RutaBase & "\graEst1.png", System.Drawing.Imaging.ImageFormat.Png)
            chrComiRamo.ExportToImage(RutaBase & "\graEst2.png", System.Drawing.Imaging.ImageFormat.Png)
            chrComiAsegAnio.ExportToImage(RutaBase & "\graEst3.png", System.Drawing.Imaging.ImageFormat.Png)
            chrComiRamoAnio.ExportToImage(RutaBase & "\graEst4.png", System.Drawing.Imaging.ImageFormat.Png)

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

    Private Sub chrComiRamoAnio_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chrComiRamoAnio.ObjectHotTracked
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

End Class