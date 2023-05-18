
Imports Utilerias.Genericas

Public Class OfertasComparativo

    Dim dtOferta As New DataTable
    Dim EditorG As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

    Private Sub OfertasComparativo_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando And Me.txtIdComparativo.Text = "" Then
            Me.txtIdComparativo.Valor = clSeguros.ObtenerID("Comparativo.Oferta")
        End If
    End Sub

    Private Sub OfertasComparativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboAseguradora.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboAseguradora.Llenar_Combo()

        cboIdRamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdRamo.Llenar_Combo()

        cboEjecutivoCta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboEjecutivoCta.Llenar_Combo()

        cboEstadoOferta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboEstadoOferta.Llenar_Combo()

        'existen corredores que no manejan la figura de ejecutivos, si no hay ejecutivos no es obligatorio
        Dim NumEjecutivos As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Usuarios where EsEjecutivo = 'S'").Tables(0).Rows(0).Item(0)
        If NumEjecutivos = 0 Then
            Me.cboEjecutivoCta.Obligatorio = False
        End If

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtFechaOferta.Valor = Date.Today
            Me.cboEstadoOferta.Valor = "PENDIENTE"
        Else
            Me.cboIdRamo.SoloLectura = True
        End If

    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
            Me.txtNombreCliente.Focus()
        End If
    End Sub

    Private Sub cboRamo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdRamo.ValueChangeOnExit
        If cboIdRamo.Text <> "" Then
            'vamos a crear una nueva estructura basada en el ramo
            Dim Fila As DataRow = Nothing, Orden As Integer = 0

            dtOferta = New DataTable
            dtOferta.Columns.Add("Orden", System.Type.GetType("System.Int32"))
            dtOferta.Columns.Add("Referente", System.Type.GetType("System.String"))
            dtOferta.Columns.Add("Suma", System.Type.GetType("System.String"))
            dtOferta.TableName = "Oferta"


            'Suma Asegurada Total
            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "Numero de Bines/Asegurados:con un Total en Sumas Aseguradas de $"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = " "
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = " COBERTURAS"
            dtOferta.Rows.Add(Fila)

            '1) Coberturas
            Dim sql As String = ""
            sql = "  select distinct cast(c.descripcion as varchar(8000)) as descripcion "
            sql &= " from ProductosCoberturas as c  "
            sql &= " where c.idproducto  = ("
            sql &= " select top 1 p.idproducto from Productos as p "
            sql &= " where p.idramo = " & dbStr(cboIdRamo.Valor)
            sql &= " )"
            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Dim FilaCob As DataRow
            For Each FilaCob In dtCoberturas.Rows
                Orden += 1
                Fila = dtOferta.NewRow
                Fila("Orden") = Orden
                Fila("Referente") = dbData(FilaCob, "descripcion")
                dtOferta.Rows.Add(Fila)
            Next

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = " "
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = " CLÁUSULAS ESPECIALES"
            dtOferta.Rows.Add(Fila)

            '2) Clausulas
            Dim dtCondiciones As DataTable = StiGlobalConn.ObtenerDataset("select Descripcion from CondicionesEspeciales where IdRamo = " & dbStr(cboIdRamo.Valor) & " order by IdCondicion").Tables(0)
            Dim FilCondicion As DataRow
            For Each FilCondicion In dtCondiciones.Rows
                Orden += 1
                Fila = dtOferta.NewRow
                Fila("Orden") = Orden
                Fila("Referente") = dbData(FilCondicion, "Descripcion")
                dtOferta.Rows.Add(Fila)
            Next

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = " "
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = " PRIMA Y GASTOS"
            dtOferta.Rows.Add(Fila)

            '3) Costos
            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "Prima Neta"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "Gastos Emisión"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "Gastos Fraccionamiento"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "Gastos Bomberos"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "Otros Gastos"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "IVA"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "Total Prima"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = " "
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "Deducible"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = "Participación"
            dtOferta.Rows.Add(Fila)

            Orden += 1
            Fila = dtOferta.NewRow
            Fila("Orden") = Orden
            Fila("Referente") = " NÚMERO DE PAGOS"
            dtOferta.Rows.Add(Fila)

            Dim Banda As DevExpress.XtraGrid.Views.BandedGrid.GridBand
            Dim TotB As Integer = Me.VistaOferta.Bands.Count
            For NB As Integer = 0 To TotB
                Try
                    Banda = Me.VistaOferta.Bands(NB)
                    If Banda.Tag <> "" Then
                        Try
                            Me.VistaOferta.Bands.Remove(Banda)
                            NB = 0
                        Catch ex As Exception

                        End Try
                    End If
                Catch ex As Exception

                End Try
            Next

            Me.VistaOferta.Columns.Clear()

            Me.GridOferta.DataSource = dtOferta
            Me.GridOferta.Refresh()

            Call FormatearVista()
        End If
    End Sub

    Private Sub btnAddAseg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAseg.Click
        If Me.cboIdRamo.Text <> "" Then
            If Me.cboAseguradora.Text <> "" Then
                Dim IdAseg As String = Me.cboAseguradora.Valor

                'verificaremos si ya existe la aseguradora 
                For I As Integer = 0 To Me.VistaOferta.Columns.Count - 1
                    If Me.VistaOferta.Columns(I).FieldName = IdAseg & "_SI" Then
                        MsgBox("La Aseguradora ya se encuentra en el comparativo.", MsgBoxStyle.Information, "AVISO...")
                        Exit Sub
                    End If
                Next

                'lo que haremos es agregar esta aseguradora al comparativo
                'se agregan 4 columna si/no/li/limitada

                dtOferta = Me.GridOferta.DataSource

                Me.GridOferta.DataSource = Nothing
                Me.VistaOferta.Columns.Clear()
                Me.GridOferta.Refresh()

                dtOferta.Columns.Add(IdAseg & "_SI", System.Type.GetType("System.Double"))
                dtOferta.Columns.Add(IdAseg & "_NO", System.Type.GetType("System.Double"))
                dtOferta.Columns.Add(IdAseg & "_LI", System.Type.GetType("System.Double"))
                dtOferta.Columns.Add(IdAseg & "_LIMITE", System.Type.GetType("System.String"))

                Me.GridOferta.DataSource = dtOferta
                Me.GridOferta.Refresh()

                'crearemos una banda sobre las nuevas columnas
                Dim bandan As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
                bandan.Caption = Me.cboAseguradora.Descripcion
                bandan.Tag = IdAseg
                bandan.Name = "Banda_" & IdAseg
                Me.VistaOferta.Bands.Add(bandan)

                Call FormatearVista()
            Else
                MsgBox("Debe especificar una aseguradora.", MsgBoxStyle.Information, "AVISO...")
            End If
        Else
            MsgBox("Debe especificar primero el ramo.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub FormatearVista()
        Dim Banda As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        For Each Banda In Me.VistaOferta.Bands
            Try
                If Banda.Tag <> "" Then
                    Try
                        Banda.Columns.Add(Me.VistaOferta.Columns(Banda.Tag & "_SI"))
                        Banda.Columns.Add(Me.VistaOferta.Columns(Banda.Tag & "_NO"))
                        Banda.Columns.Add(Me.VistaOferta.Columns(Banda.Tag & "_LI"))
                        Banda.Columns.Add(Me.VistaOferta.Columns(Banda.Tag & "_LIMITE"))

                        Me.VistaOferta.Columns(Banda.Tag & "_SI").Caption = "SI"
                        Me.VistaOferta.Columns(Banda.Tag & "_SI").Width = 35
                        Me.VistaOferta.Columns(Banda.Tag & "_SI").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                        Me.VistaOferta.Columns(Banda.Tag & "_SI").SummaryItem.DisplayFormat = "{0:#,###0.0}"
                        Me.VistaOferta.Columns(Banda.Tag & "_SI").SummaryItem.FieldName = Banda.Tag & "_SI"


                        Me.VistaOferta.Columns(Banda.Tag & "_NO").Caption = "NO"
                        Me.VistaOferta.Columns(Banda.Tag & "_NO").Width = 35
                        Me.VistaOferta.Columns(Banda.Tag & "_NO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                        Me.VistaOferta.Columns(Banda.Tag & "_NO").SummaryItem.DisplayFormat = "{0:#,###0.0}"
                        Me.VistaOferta.Columns(Banda.Tag & "_NO").SummaryItem.FieldName = Banda.Tag & "_NO"

                        Me.VistaOferta.Columns(Banda.Tag & "_LI").Caption = "LI"
                        Me.VistaOferta.Columns(Banda.Tag & "_LI").Width = 35
                        Me.VistaOferta.Columns(Banda.Tag & "_LI").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                        Me.VistaOferta.Columns(Banda.Tag & "_LI").SummaryItem.DisplayFormat = "{0:#,###0.0}"
                        Me.VistaOferta.Columns(Banda.Tag & "_LI").SummaryItem.FieldName = Banda.Tag & "_LI"


                        Me.VistaOferta.Columns(Banda.Tag & "_LIMITE").Caption = "LIMITADO A:"
                        Me.VistaOferta.Columns(Banda.Tag & "_LIMITE").Width = 100
                        'en esta columna daremos el resultado de la aseguradora
                        Me.VistaOferta.Columns(Banda.Tag & "_LIMITE").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
                        Me.VistaOferta.Columns(Banda.Tag & "_LIMITE").SummaryItem.DisplayFormat = "RESULTADO: {0}"
                        Me.VistaOferta.Columns(Banda.Tag & "_LIMITE").SummaryItem.FieldName = Banda.Tag & "_LIMITE"

                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception

            End Try
        Next
        Try
            Me.VistaOferta.Columns("Orden").Visible = False
        Catch ex As Exception

        End Try
        Try
            Me.VistaOferta.Columns("Referente").Width = 400
            Me.VistaOferta.Columns("Referente").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.VistaOferta.Columns("Referente").SummaryItem.DisplayFormat = " PUNTUACIÓN"
            Me.VistaOferta.Columns("Referente").SummaryItem.FieldName = "Referente"
            Me.VistaOferta.Columns("Referente").ColumnEdit = EditorG

            Me.VistaOferta.Columns("Suma").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.VistaOferta.Columns("Suma").DisplayFormat.FormatString = "c"

            Me.VistaOferta.Columns("Orden").SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
            Me.VistaOferta.Columns("Orden").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim SubKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
            Dim Archivo As String = SubKey.GetValue("Personal") & "\Reporte" & Me.Name & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridOferta.ExportToXls(Archivo, Opciones)
            FormatearReporte(Archivo)
        Catch ex As Exception
            msgError(ex)
            'MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub FormatearReporte(ByVal FileName As String)
        Dim Miexcel As Object = Nothing, Hoja As Object = Nothing
        Try
            Miexcel = CreateObject("Excel.Application")
            Miexcel.Workbooks.Open(FileName)
            Hoja = Miexcel.Worksheets(1)

            'insertamos 5 filas al inicio
            Hoja.Range("A1").Select()
            Miexcel.Selection.EntireRow.Insert()
            Hoja.Range("A1").Select()
            Miexcel.Selection.EntireRow.Insert()
            Hoja.Range("A1").Select()
            Miexcel.Selection.EntireRow.Insert()
            Hoja.Range("A1").Select()
            Miexcel.Selection.EntireRow.Insert()
            Hoja.Range("A1").Select()
            Miexcel.Selection.EntireRow.Insert()

            Hoja.Cells(1, 1).Value = "TERMINOS TECNICOS PARA SOLICITUD DE OFERTA"
            Hoja.Cells(2, 1).Value = txtNombreCliente.Valor
            Hoja.Cells(3, 1).Value = "Vigencia de la póliza: " & Format(CDate(txtFechaOferta.Valor), "Long Date")
            Hoja.Cells(4, 1).Value = ""

            'centramos las celdas
            Hoja.Cells(1, 1).HorizontalAlignment = -4108
            Hoja.Cells(2, 1).HorizontalAlignment = -4108
            Hoja.Cells(3, 1).HorizontalAlignment = -4108


            Hoja.Rows("1:4").Select()
            Miexcel.Selection.Font.Bold = True
            Hoja.Range("A1").Select()

            'determinaremos cuantas aseguradoras hay para reducir el zoom
            Dim lstAseg As String = ""
            For NC As Integer = 0 To Me.VistaOferta.Columns.Count - 1
                If stiSplit(Me.VistaOferta.Columns(NC).FieldName, "G1_1").Trim.ToUpper = "SI" Then
                    If lstAseg = "" Then
                        lstAseg = stiSplit(Me.VistaOferta.Columns(NC).FieldName, "G0_1").Trim.ToUpper
                    Else
                        lstAseg &= "|" & stiSplit(Me.VistaOferta.Columns(NC).FieldName, "G0_1").Trim.ToUpper
                    End If
                End If
            Next

            Dim NumAseg As Integer = CuentaCar(lstAseg, "|") + 1
            Dim ultimaFila As Integer = 0
            Dim Dato As String = ""
            ultimaFila = 8
            While Hoja.Cells(ultimaFila, 1).Value <> ""
                ultimaFila += 1
            End While

            Try
                Hoja.Columns("A:A").ColumnWidth = 70
                Hoja.PageSetup.Orientation = 2  'horizontal
                Hoja.PageSetup.Zoom = 100 - (NumAseg * 5)
                Hoja.Rows("8:" & ultimaFila).Select()
                Hoja.Rows("8:" & ultimaFila).EntireRow.AutoFit()
                Hoja.Cells(1, 1).Select()
            Catch ex As Exception

            End Try

            'ingresamos el logo
            Try
                If System.IO.File.Exists(RutaLogo) Then
                    Dim P As Object
                    P = Hoja.Pictures.Insert(RutaLogo)
                    Dim posTop As Integer = Hoja.Range("C1:F5").Top
                    Dim posLeft As Integer = Hoja.Range("C1:F5").Left
                    Dim imgHeight As Integer = Hoja.Range("C1:F5").Offset(Hoja.Range("C1:F5").Rows.Count, 0).Top - Hoja.Range("C1:F5").Top
                    Dim imgWidth As Integer = Hoja.Range("C1:F5").Offset(0, Hoja.Range("C1:F5").Columns.Count).Left - Hoja.Range("C1:F5").Left
                    P.Top = posTop
                    P.Left = posLeft
                    P.Width = imgWidth
                    P.Height = imgHeight
                End If
            Catch ex As Exception
                'si hay prolemas con logo no validamos, algunas versiones de offic pueden fallar
            End Try

        Catch ex As Exception
            msgError(ex)
        Finally
            If Not Miexcel Is Nothing Then
                Miexcel.Workbooks(1).Save()
                Miexcel.Visible = True
            End If
            Miexcel = Nothing
            Hoja = Nothing
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub VistaOferta_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles VistaOferta.CustomSummaryCalculate
        Try
            Dim SumItem As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
            Dim Aseg As String = stiSplit(SumItem.FieldName, "G0_1")
            Dim TotalSI As Double = Val(Me.VistaOferta.Columns(Aseg & "_SI").SummaryText)
            Dim TotalNO As Double = Val(Me.VistaOferta.Columns(Aseg & "_NO").SummaryText)
            Dim TotalLI As Double = Val(Me.VistaOferta.Columns(Aseg & "_LI").SummaryText)
            e.TotalValue = (TotalSI + TotalLI) - TotalNO
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OfertasComparativo_DespuesDeGuardar() Handles Me.DespuesDeGuardar

        'primero borramos los datos relacionados y lo volvemos a guardar
        StiGlobalConn.SQLExecute("delete from OfertasComparativoAseguradora where IdComparativo = " & dbStr(txtIdComparativo.Valor))
        StiGlobalConn.SQLExecute("delete from OfertasComparativoDetalle where IdComparativo = " & dbStr(txtIdComparativo.Valor))

        Dim SQL As String = ""
        Dim lstAseg As String = ""
        For NC As Integer = 0 To Me.VistaOferta.Columns.Count - 1
            If stiSplit(Me.VistaOferta.Columns(NC).FieldName, "G1_1").Trim.ToUpper = "SI" Then
                If lstAseg = "" Then
                    lstAseg = stiSplit(Me.VistaOferta.Columns(NC).FieldName, "G0_1").Trim.ToUpper
                Else
                    lstAseg &= "|" & stiSplit(Me.VistaOferta.Columns(NC).FieldName, "G0_1").Trim.ToUpper
                End If
            End If
        Next
        Dim NumAseg As Integer = CuentaCar(lstAseg, "|")
        Dim IdAseguradora As String = ""

        'ingresamos los datos detalle
        For ND As Integer = 0 To Me.VistaOferta.DataRowCount - 1
            SQL = " insert into OfertasComparativoDetalle "
            SQL &= " (IdComparativo, IdDetalle, Referente, Suma) values("
            SQL &= dbStr(txtIdComparativo.Valor) & C & dbInt(VistaOferta.GetRowCellValue(ND, "Orden")) & C & dbStr(VistaOferta.GetRowCellValue(ND, "Referente")) & C & dbNum(VistaOferta.GetRowCellValue(ND, "Suma")) & ")"
            StiGlobalConn.SQLExecute(SQL)

            'ahora ingresaremos el detalle por cada aseguradora.
            If lstAseg <> "" Then
                For NA As Integer = 0 To NumAseg
                    IdAseguradora = stiSplit(lstAseg, "G" & NA & "|1")

                    SQL = " insert into OfertasComparativoAseguradora "
                    SQL &= " (IdComparativo, IdDetalle, IdAseguradora, ValorSI, ValorNO, Limitada, ValorLI) values ("
                    SQL &= dbStr(txtIdComparativo.Valor) & C & dbInt(VistaOferta.GetRowCellValue(ND, "Orden")) & C & dbStr(IdAseguradora) & C & dbNum(VistaOferta.GetRowCellValue(ND, IdAseguradora & "_SI")) & C & dbNum(VistaOferta.GetRowCellValue(ND, IdAseguradora & "_NO")) & C & dbStr(VistaOferta.GetRowCellValue(ND, IdAseguradora & "_LIMITE"), 500) & C & dbNum(VistaOferta.GetRowCellValue(ND, IdAseguradora & "_LI")) & ")"
                    StiGlobalConn.SQLExecute(SQL)
                Next
            End If
        Next

    End Sub

    Private Sub OfertasComparativo_AntesDeEliminar(ByRef Cancel As Boolean) Handles Me.AntesDeEliminar
        'borramos los datos relacionados y lo volvemos a guardar
        StiGlobalConn.SQLExecute("delete from OfertasComparativoAseguradora where IdComparativo = " & dbStr(txtIdComparativo.Valor))
        StiGlobalConn.SQLExecute("delete from OfertasComparativoDetalle where IdComparativo = " & dbStr(txtIdComparativo.Valor))
    End Sub

    Private Sub OfertasComparativo_DespuesDeCargarRegistro() Handles Me.DespuesDeCargarRegistro
        'vamos a cargar generar la información del grid.
        If Me.txtIdComparativo.Text <> "" Then

            Me.GridOferta.DataSource = Nothing
            Me.VistaOferta.Columns.Clear()
            Me.GridOferta.Refresh()

            dtOferta = New DataTable
            dtOferta = StiGlobalConn.ObtenerDataset("select IdDetalle as Orden, Referente, Suma from OfertasComparativoDetalle where IdComparativo = " & dbStr(txtIdComparativo.Valor) & " order by IdDetalle asc").Tables(0)
            dtOferta.TableName = "Oferta"

            'ahora le completaremos la informacion de las aseguradoras
            Dim Aseg As DataTable = StiGlobalConn.ObtenerDataset("select distinct IdAseguradora from OfertasComparativoAseguradora where IdComparativo = " & dbStr(txtIdComparativo.Valor) & " order by IdAseguradora").Tables(0)
            Dim FilAseg As DataRow, FilOferta As DataRow, FilDato As DataRow
            For Each FilAseg In Aseg.Rows
                dtOferta.Columns.Add(dbData(FilAseg, "IdAseguradora") & "_SI", System.Type.GetType("System.Double"))
                dtOferta.Columns.Add(dbData(FilAseg, "IdAseguradora") & "_NO", System.Type.GetType("System.Double"))
                dtOferta.Columns.Add(dbData(FilAseg, "IdAseguradora") & "_LI", System.Type.GetType("System.Double"))
                dtOferta.Columns.Add(dbData(FilAseg, "IdAseguradora") & "_LIMITE", System.Type.GetType("System.String"))
                'ahora por cada fila en DtOferta completaremos el detalle almacenado de cada aseguradora
                For Each FilOferta In dtOferta.Rows
                    Try
                        FilDato = StiGlobalConn.ObtenerDataset("select ValorSI, ValorNO, Limitada, ValorLI from OfertasComparativoAseguradora where IdComparativo = " & dbStr(txtIdComparativo.Valor) & " and IdDetalle = " & dbInt(dbData(FilOferta, "Orden")) & " and IdAseguradora = " & dbStr(dbData(FilAseg, "IdAseguradora"))).Tables(0).Rows(0)
                        FilOferta(dbData(FilAseg, "IdAseguradora") & "_SI") = FilDato("ValorSI")
                        FilOferta(dbData(FilAseg, "IdAseguradora") & "_NO") = FilDato("ValorNO")
                        FilOferta(dbData(FilAseg, "IdAseguradora") & "_LI") = FilDato("ValorLI")
                        FilOferta(dbData(FilAseg, "IdAseguradora") & "_LIMITE") = FilDato("Limitada")
                    Catch ex As Exception

                    End Try
                Next
                'ahora creamos la banda
                Dim bandan As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
                bandan.Caption = StiGlobalConn.ObtenerDataset("select Nombre from Aseguradoras where IdAseguradora = " & dbStr(dbData(FilAseg, "IdAseguradora"))).Tables(0).Rows(0).Item(0)
                bandan.Tag = dbData(FilAseg, "IdAseguradora")
                bandan.Name = "Banda_" & dbData(FilAseg, "IdAseguradora")
                Me.VistaOferta.Bands.Add(bandan)
            Next
            dtOferta.AcceptChanges()

            Me.GridOferta.DataSource = dtOferta
            Me.GridOferta.Refresh()

            Call FormatearVista()
        End If
    End Sub

    Private Sub btnEliminarRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarRef.Click
        Try
            Dim Fila As Integer = Me.VistaOferta.FocusedRowHandle
            If Fila >= 0 Then
                Me.VistaOferta.DeleteRow(Fila)
                Me.VistaOferta.GridControl.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRef.Click
        Try
            'lo que haremos es insertar donde este el focus la nueva fila
            Dim Fila As Integer = Me.VistaOferta.FocusedRowHandle
            If Fila >= 0 Then
                Dim Orden As Integer = VistaOferta.GetRowCellValue(Fila, "Orden")
                For NF As Integer = 0 To Me.VistaOferta.DataRowCount - 1
                    If CInt(VistaOferta.GetRowCellValue(NF, "Orden")) >= Val(Orden) Then
                        VistaOferta.SetRowCellValue(NF, "Orden", CInt(VistaOferta.GetRowCellValue(NF, "Orden")) + 1)
                    End If
                Next
                VistaOferta.AddNewRow()
                VistaOferta.SetRowCellValue(VistaOferta.FocusedRowHandle, "Orden", Orden)
                Me.VistaOferta.UpdateCurrentRow()
                Me.VistaOferta.GridControl.Focus()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnRemAseg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemAseg.Click
        If Me.cboIdRamo.Text <> "" Then
            If Me.cboAseguradora.Text <> "" Then
                Dim IdAseg As String = Me.cboAseguradora.Valor

                dim Existe as integer = 0
                'verificaremos si ya existe la aseguradora 
                For I As Integer = 0 To Me.VistaOferta.Columns.Count - 1
                    If Me.VistaOferta.Columns(I).FieldName = IdAseg & "_SI" Then
                        Existe = 1
                        Exit For
                    End If
                Next
                If Existe = 0  Then
                    MsgBox("La aseguradora seleccionada no se encuentra en el cuadro comparativo", MsgBoxStyle.Information, "AVISO...")
                    exit sub 
                End If

                'lo que haremos es agregar esta aseguradora al comparativo
                'se agregan 3 columna si/no/limitada

                dtOferta = Me.GridOferta.DataSource

                Me.GridOferta.DataSource = Nothing
                Me.VistaOferta.Columns.Clear()
                Me.GridOferta.Refresh()
                Try
                    dtOferta.Columns.Remove(IdAseg & "_SI")
                    dtOferta.Columns.Remove(IdAseg & "_NO")
                    dtOferta.Columns.Remove(IdAseg & "_LI")
                    dtOferta.Columns.Remove(IdAseg & "_LIMITE")
                Catch ex As Exception

                End Try

                'borramos la banda

                Try
                    Me.VistaOferta.Bands.Remove(Me.VistaOferta.Bands("Banda_" & IdAseg))
                Catch ex As Exception

                End Try
                Me.GridOferta.DataSource = dtOferta
                Me.GridOferta.Refresh()

                Call FormatearVista()
            Else
                MsgBox("Debe especificar una aseguradora.", MsgBoxStyle.Information, "AVISO...")
            End If
        Else
            MsgBox("Debe especificar primero el ramo.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

End Class
