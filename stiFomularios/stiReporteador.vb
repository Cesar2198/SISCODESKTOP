Imports Utilerias.Genericas

Public Class stiReporteador

    Public PassWordDoc As String = ""

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        'esta opción nos permitirá generar los reportes hacia archivos planos de excel.
        btnExcel.Enabled = False
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        Try
            'Solucion Crystal c2014430 ***********************************************
            Dim excelo As New CrystalDecisions.Shared.ExcelFormatOptions
            excelo.ExcelUseConstantColumnWidth = False
            excelo.ExcelAreaGroupNumber = 1
            excelo.ExcelAreaType = CrystalDecisions.[Shared].AreaSectionKind.Detail
            Dim disk As New CrystalDecisions.Shared.DiskFileDestinationOptions
            Dim Ruta As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\CRTemp" & Format(Date.Now, "ddMMyyyyHHmmss") & ".xls"
            disk.DiskFileName = Ruta
            Dim export As CrystalDecisions.Shared.ExportOptions = Me.CRViewer.ReportSource.ExportOptions
            export.FormatOptions = excelo
            export.ExportFormatType = CrystalDecisions.[Shared].ExportFormatType.Excel
            export.ExportDestinationType = CrystalDecisions.[Shared].ExportDestinationType.DiskFile

            export.DestinationOptions = disk
            Me.CRViewer.ReportSource.Export()
            'Ahora que esta listo el archivo lo abrimos
            EstablecerPasswordExcelYAbrir(Ruta, PassWordDoc)
            'AbrirArchivo(Ruta)
        Catch ex As Exception
            MsgBox("Error al exportar el reporte: " & vbCrLf & ex.ToString, MsgBoxStyle.Exclamation, "ERROR...")
        End Try
        Me.Cursor = Windows.Forms.Cursors.Default
        btnExcel.Enabled = True
    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        'esta opción nos permitirá generar los reportes hacia archivos pdf.
        btnPDF.Enabled = False
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        Try
            'Solucion Crystal c2014430 ***********************************************
            Dim excelo As New CrystalDecisions.Shared.PdfRtfWordFormatOptions

            'excelo.ExcelUseConstantColumnWidth = False
            'excelo.ExcelAreaGroupNumber = 1
            'excelo.ExcelAreaType = CrystalDecisions.[Shared].AreaSectionKind.Detail

            Dim disk As New CrystalDecisions.Shared.DiskFileDestinationOptions
            Dim Ruta As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\CRTemp" & Format(Date.Now, "ddMMyyyyHHmmss") & ".pdf"
            disk.DiskFileName = Ruta
            Dim export As CrystalDecisions.Shared.ExportOptions = Me.CRViewer.ReportSource.ExportOptions
            export.FormatOptions = excelo
            export.ExportFormatType = CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat
            export.ExportDestinationType = CrystalDecisions.[Shared].ExportDestinationType.DiskFile

            export.DestinationOptions = disk
            Me.CRViewer.ReportSource.Export()
            AbrirArchivo(Ruta)
        Catch ex As Exception
            MsgBox("Error al exportar el reporte: " & vbCrLf & ex.ToString, MsgBoxStyle.Exclamation, "ERROR...")
        End Try
        Me.Cursor = Windows.Forms.Cursors.Default
        btnPDF.Enabled = True
    End Sub

    Private Sub btnWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWord.Click
        'esta opción nos permitirá generar los reportes hacia archivos word.
        btnWord.Enabled = False
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        Try
            'Solucion Crystal c2014430 ***********************************************
            Dim excelo As New CrystalDecisions.Shared.PdfRtfWordFormatOptions

            'excelo.ExcelUseConstantColumnWidth = False
            'excelo.ExcelAreaGroupNumber = 1
            'excelo.ExcelAreaType = CrystalDecisions.[Shared].AreaSectionKind.Detail

            Dim disk As New CrystalDecisions.Shared.DiskFileDestinationOptions
            Dim Ruta As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\CRTemp" & Format(Date.Now, "ddMMyyyyHHmmss") & ".doc"
            disk.DiskFileName = Ruta
            Dim export As CrystalDecisions.Shared.ExportOptions = Me.CRViewer.ReportSource.ExportOptions
            export.FormatOptions = excelo
            export.ExportFormatType = CrystalDecisions.[Shared].ExportFormatType.WordForWindows
            export.ExportDestinationType = CrystalDecisions.[Shared].ExportDestinationType.DiskFile

            export.DestinationOptions = disk
            Me.CRViewer.ReportSource.Export()

            'Ahora que esta listo el archivo lo abrimos
            EstablecerPasswordWordYAbrir(Ruta, PassWordDoc)
            'AbrirArchivo(Ruta)
        Catch ex As Exception
            MsgBox("Error al exportar el reporte: " & vbCrLf & ex.ToString, MsgBoxStyle.Exclamation, "ERROR...")
        End Try
        Me.Cursor = Windows.Forms.Cursors.Default
        btnWord.Enabled = True
    End Sub

End Class