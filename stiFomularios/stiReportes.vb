Imports Utilerias.Genericas
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class stiReportes

    Public STIConn As Conectividad.Funciones

    Private AyudaIdL As Integer = 0
    <Category("Administración Formularios"), Description("Determina el número de ID de la ayuda en el archivo de ayuda.")> _
    Public Property AyudaId() As Integer
        Get
            Return AyudaIdL
        End Get
        Set(ByVal value As Integer)
            AyudaIdL = value
        End Set
    End Property

    Private PermisoL As String = ""
    Public Property Permiso() As String
        Get
            Return PermisoL
        End Get
        Set(ByVal value As String)
            PermisoL = value
        End Set
    End Property

    Private Sub stiReportes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dim RecordarVista As String = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Vistas'").Tables(0).Rows(0).Item(0)
            If RecordarVista.Trim.ToUpper = "S" Then
                AlmacenarVistas(Me)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub stiReportes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ValidarPermiso()

        'varificaremos si las vistas de grid están almacenadas.
        Try
            Dim RecordarVista As String = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Vistas'").Tables(0).Rows(0).Item(0)
            If RecordarVista.Trim.ToUpper = "S" Then
                PrepararVistas(Me)
            End If
        Catch ex As Exception

        End Try

        Call PrepararPersonalizacion(Me)
        Call PersonalizarCampo()
        Call PersonalizarVistas(Me)
    End Sub

    Public Sub PrepararVistas(ByRef ControlL As System.Windows.Forms.Control)
        For Each ControlL1 As Object In ControlL.Controls
            Try
                If TypeOf ControlL1 Is STIControles.stiGrid Then
                    Dim VistaAlmacenada As String = "", FiltroAlmacenado As String = ""
                    Try
                        VistaAlmacenada = STIConn.ObtenerDataset("select ModeloVista from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        VistaAlmacenada = ""
                    End Try
                    Dim RecordarFiltro As String = ""
                    Try
                        RecordarFiltro = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Filtros'").Tables(0).Rows(0).Item(0)
                    Catch ex As Exception

                    End Try

                    If RecordarFiltro.Trim.ToUpper = "S" Then
                        Try
                            FiltroAlmacenado = STIConn.ObtenerDataset("select ModeloVista from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro")).Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            FiltroAlmacenado = ""
                        End Try
                    End If

                    If VistaAlmacenada <> "" Then
                        Call PrepararGrid(ControlL1.Views(0), VistaAlmacenada, FiltroAlmacenado)
                    End If
                End If
            Catch ex As Exception

            End Try

            Try
                If TypeOf ControlL1 Is DevExpress.XtraPivotGrid.PivotGridControl Then
                    Dim VistaAlmacenada As String = STIConn.ObtenerDataset("select ModeloVista from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                    If VistaAlmacenada <> "" Then
                        Call PrepararPivot(ControlL1, VistaAlmacenada)
                    End If
                End If
            Catch ex As Exception

            End Try


            If ControlL1.Controls.Count > 0 Then
                PrepararVistas(ControlL1)
            End If
        Next
    End Sub

    Public Sub AlmacenarVistas(ByRef ControlL As System.Windows.Forms.Control)
        For Each ControlL1 As Object In ControlL.Controls
            Try
                If TypeOf ControlL1 Is STIControles.stiGrid Then
                    Dim VistaAlmacenada As String = ObtenerVista(ControlL1.Views(0))
                    If VistaAlmacenada <> "" Then
                        Dim Existe As Integer = STIConn.ObtenerDataset("select count(*) from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                        If Existe > 0 Then
                            STIConn.SQLExecute("update VistasUsuarios set ModeloVista = " & dbStr(VistaAlmacenada) & " where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name))
                        Else
                            STIConn.SQLExecute("insert into VistasUsuarios (IdUsuario, IdVista, ModeloVista) values(" & dbStr(STIConn.User) & C & dbStr(Me.Name & "." & ControlL1.Name) & C & dbStr(VistaAlmacenada) & ")")
                        End If
                        Dim RecordarFiltro As String = ""
                        Try
                            RecordarFiltro = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Filtros'").Tables(0).Rows(0).Item(0)
                        Catch ex As Exception

                        End Try

                        If RecordarFiltro.Trim.ToUpper = "S" Then
                            'guaradmos el filtro
                            Existe = STIConn.ObtenerDataset("select count(*) from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro")).Tables(0).Rows(0).Item(0)
                            If Existe > 0 Then
                                STIConn.SQLExecute("update VistasUsuarios set ModeloVista = " & dbStr(ControlL1.Views(0).ActiveFilterString) & " where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro"))
                            Else
                                STIConn.SQLExecute("insert into VistasUsuarios (IdUsuario, IdVista, ModeloVista) values(" & dbStr(STIConn.User) & C & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro") & C & dbStr(ControlL1.Views(0).ActiveFilterString) & ")")
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try
            Try
                If TypeOf ControlL1 Is DevExpress.XtraPivotGrid.PivotGridControl Then
                    Dim VistaAlmacenada As String = ObtenerVistaPivot(ControlL1)
                    If VistaAlmacenada <> "" Then
                        Dim Existe As Integer = STIConn.ObtenerDataset("select count(*) from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                        If Existe > 0 Then
                            STIConn.SQLExecute("update VistasUsuarios set ModeloVista = " & dbStr(VistaAlmacenada) & " where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name))
                        Else
                            STIConn.SQLExecute("insert into VistasUsuarios (IdUsuario, IdVista, ModeloVista) values(" & dbStr(STIConn.User) & C & dbStr(Me.Name & "." & ControlL1.Name) & C & dbStr(VistaAlmacenada) & ")")
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try

            If ControlL1.Controls.Count > 0 Then
                AlmacenarVistas(ControlL1)
            End If
        Next
    End Sub

    Public Function ObtenerVista(ByRef Vista As DevExpress.XtraGrid.Views.Grid.GridView) As String
        Dim res As String = ""
        Try
            For Each ColVista As DevExpress.XtraGrid.Columns.GridColumn In Vista.VisibleColumns
                If res = "" Then
                    res = ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                Else
                    res &= "," & ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                End If
            Next

            'las agrupadas
            For Each ColVista As DevExpress.XtraGrid.Columns.GridColumn In Vista.GroupedColumns
                If res = "" Then
                    res = ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                Else
                    res &= "," & ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                End If
            Next
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Function ObtenerVistaPivot(ByRef Pivot As DevExpress.XtraPivotGrid.PivotGridControl) As String
        Dim res As String = ""
        Try
            For Each ColVista As DevExpress.XtraPivotGrid.PivotGridField In Pivot.Fields
                If res = "" Then
                    res = ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenPivot(ColVista.SortOrder) & "|" & ObtenetAreaPivot(ColVista.Area) & "|" & ColVista.AreaIndex
                Else
                    res &= "," & ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenPivot(ColVista.SortOrder) & "|" & ObtenetAreaPivot(ColVista.Area) & "|" & ColVista.AreaIndex
                End If
            Next
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Function ObtenetOrdenGrid(ByVal Orden As DevExpress.Data.ColumnSortOrder) As String
        Dim res As String = ""
        Select Case Orden
            Case DevExpress.Data.ColumnSortOrder.None
                res = ""
            Case DevExpress.Data.ColumnSortOrder.Ascending
                res = "A"
            Case DevExpress.Data.ColumnSortOrder.Descending
                res = "D"
        End Select
        Return res
    End Function

    Public Function ObtenerColumnSortOrder(ByVal Orden As String) As DevExpress.Data.ColumnSortOrder
        Dim res As DevExpress.Data.ColumnSortOrder
        Select Case Orden.Trim.ToUpper
            Case "A"
                res = DevExpress.Data.ColumnSortOrder.Ascending
            Case "D"
                res = DevExpress.Data.ColumnSortOrder.Descending
            Case Else
                res = DevExpress.Data.ColumnSortOrder.None
        End Select
        Return res
    End Function

    Public Function ObtenetOrdenPivot(ByVal Orden As DevExpress.XtraPivotGrid.PivotSortOrder) As String
        Dim res As String = ""
        Select Case Orden
            Case DevExpress.XtraPivotGrid.PivotSortOrder.Ascending
                res = "A"
            Case DevExpress.XtraPivotGrid.PivotSortOrder.Descending
                res = "D"
        End Select
        Return res
    End Function

    Public Function ObtenetOrdenPivotGrid(ByVal Orden As String) As DevExpress.XtraPivotGrid.PivotSortOrder
        Dim res As DevExpress.XtraPivotGrid.PivotSortOrder
        Select Case Orden
            Case "A"
                res = DevExpress.XtraPivotGrid.PivotSortOrder.Ascending
            Case "D"
                res = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        End Select
        Return res
    End Function

    Public Function ObtenetAreaPivot(ByVal Area As DevExpress.XtraPivotGrid.PivotArea) As String
        Dim res As String = ""
        Select Case Area
            Case DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                res = "C"
            Case DevExpress.XtraPivotGrid.PivotArea.DataArea
                res = "D"
            Case DevExpress.XtraPivotGrid.PivotArea.FilterArea
                res = "F"
            Case DevExpress.XtraPivotGrid.PivotArea.RowArea
                res = "R"
        End Select
        Return res
    End Function

    Public Function ObtenerAreaPivotGrid(ByVal Area As String) As DevExpress.XtraPivotGrid.PivotArea
        Dim res As DevExpress.Data.ColumnSortOrder
        Select Case Area.Trim.ToUpper
            Case "C"
                res = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Case "D"
                res = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Case "F"
                res = DevExpress.XtraPivotGrid.PivotArea.FilterArea
            Case "R"
                res = DevExpress.XtraPivotGrid.PivotArea.RowArea
        End Select
        Return res
    End Function

    Public Sub PrepararGrid(ByRef Vista As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Columnas As String, ByVal FiltroVista As String)
        'lo que se hará es mostrar las columna solicitadas y en el orden solicitado
        Try
            'primero las ocultamos
            If Columnas.Trim.Length = 0 Then Exit Sub
            For Each Col As DevExpress.XtraGrid.Columns.GridColumn In Vista.Columns
                If InStr(Columnas, Col.FieldName) > 0 Then
                    Col.Visible = True
                Else
                    Col.Visible = False
                End If
            Next
            'ahora las ordenamos
            Vista.BeginSort()
            Vista.ClearGrouping()
            Dim NumCampos As Integer = CuentaCar(Columnas, ",")
            Dim busColumna As String = "", AnchoCol As Double = 0, OrdenCol As DevExpress.Data.ColumnSortOrder = DevExpress.Data.ColumnSortOrder.None, GroupIndexCol As Integer = 0
            For I As Integer = 0 To NumCampos
                busColumna = stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G0|1").Trim
                AnchoCol = Val(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G1|1").Trim)
                OrdenCol = ObtenerColumnSortOrder(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G2|1").Trim)
                GroupIndexCol = CInt(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G3|1").Trim)

                Try
                    Vista.Columns(busColumna).VisibleIndex = I
                    Vista.Columns(busColumna).Width = AnchoCol
                    Vista.Columns(busColumna).SortOrder = OrdenCol
                    If GroupIndexCol >= 0 Then
                        Vista.Columns(busColumna).GroupIndex = GroupIndexCol
                    End If

                Catch ex As Exception

                End Try
            Next
            Vista.EndSort()
            Vista.ActiveFilterString = FiltroVista

            'autoajustamos las columans
            'Vista.BestFitColumns()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub PrepararPivot(ByRef Pivot As DevExpress.XtraPivotGrid.PivotGridControl, ByVal Columnas As String)
        'lo que se hará es mostrar las columna solicitadas y en el orden solicitado
        Try
            Dim NumCampos As Integer = CuentaCar(Columnas, ",")
            Dim busColumna As String = "", AnchoCol As Double = 0, OrdenCol As DevExpress.XtraPivotGrid.PivotSortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Ascending, AreaCol As DevExpress.XtraPivotGrid.PivotArea, AreaIndex As Integer = 0
            For I As Integer = 0 To NumCampos
                busColumna = stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G0|1").Trim
                AnchoCol = Val(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G1|1").Trim)
                OrdenCol = ObtenetOrdenPivotGrid(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G2|1").Trim)
                AreaCol = ObtenerAreaPivotGrid(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G3|1").Trim)
                AreaIndex = CInt(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G4|1").Trim)
                Try
                    Pivot.Fields(busColumna).Area = AreaCol
                    Pivot.Fields(busColumna).Width = AnchoCol
                    Pivot.Fields(busColumna).SortOrder = OrdenCol
                    Pivot.Fields(busColumna).AreaIndex = AreaIndex
                    Pivot.Fields(busColumna).FilterValues.Clear()
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        Call funLanzarAyuda(Me, AyudaId)
    End Sub

    Private Sub ValidarPermiso()
        Select Case Me.PermisoL
            Case "I"
                'solo lectura sin impresión deshabilitamos
                Me.btnImprimir.Enabled = False
        End Select
    End Sub

    Public Function ValidarCamposObligatorios(ByRef Control As System.Windows.Forms.Control) As String
        Dim res As String = ""
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Then
                If ControlL.Obligatorio = True And ControlL.Text = "" Then
                    res &= ControlL.LabelText & "; "
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    res &= ValidarCamposObligatorios(ControlL)
                End If
            End If
        Next
        Return res
    End Function

    Public Sub LimpiarCampos(ByRef Control As System.Windows.Forms.Control)
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Then
                ControlL.Valor = ""
            ElseIf TypeOf ControlL Is STIControles.stiGrid Then
                ControlL.DataSource = Nothing : ControlL.Refresh()
            ElseIf ControlL.Controls.Count > 0 Then
                LimpiarCampos(ControlL)
            End If
        Next
    End Sub

#Region "Personalizar Nombre de  Campos"

    Private Sub PersonalizarNombreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalizarNombreToolStripMenuItem.Click
        Try
            Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
            Dim Control As Object = cms.SourceControl
            Dim Forma As String = Me.Name
            Dim Campo As String = Control.Name
            Dim Nombre As String = ""
            If TypeOf Control Is STIControles.stiTextBox Or TypeOf Control Is STIControles.stiMemo Or TypeOf Control Is STIControles.stiComboBox Then
                Nombre = Control.LabelText
            End If
            If TypeOf Control Is DevExpress.XtraEditors.LabelControl Or TypeOf Control Is Label Then
                Nombre = Control.Text
            End If

            Dim FrmPerCampo As New stiPersonalizaCampo
            FrmPerCampo.Forma = Forma
            FrmPerCampo.Campo = Campo
            FrmPerCampo.Nombre = Nombre
            FrmPerCampo.STIConn = Me.STIConn
            Try
                FrmPerCampo.Obligatorio = "0"
                If Control.Obligatorio = True Then
                    FrmPerCampo.Obligatorio = "1"
                End If
            Catch ex As Exception
                FrmPerCampo.Obligatorio = ""
            End Try
            FrmPerCampo.ShowDialog()
            Call PersonalizarCampo()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VolverANombreOriginalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverANombreOriginalToolStripMenuItem.Click
        Try
            Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
            Dim Control As Object = cms.SourceControl
            Dim Forma As String = Me.Name
            Dim Campo As String = Control.Name
            Dim Nombre As String = ""
            STIConn.SQLExecute("delete from VistasCampos where forma = " & dbStr(Forma) & " and campo = " & dbStr(Campo))
            MsgBox("El cambio ha sido registrado con éxito, tendrá efecto al volver a abrir el formulario.", MsgBoxStyle.Information, "AVISO...")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrepararPersonalizacion(ByRef Control As System.Windows.Forms.Control)
        Try
            'ojo solo administradores podrán hacer estos cambios
            If STIConn.UsuarioPerteneceAGrupo(STIConn.User, "ADMINISTRADORES") = False Then Exit Sub

            For Each ControlL In Control.Controls
                If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is Label Or TypeOf ControlL Is DevExpress.XtraEditors.LabelControl Then
                    ControlL.ContextMenuStrip = mnuCampos
                ElseIf TypeOf ControlL Is STIControles.stiGrid Then
                    AddHandler CType(ControlL.Views(0), DevExpress.XtraGrid.Views.Grid.GridView).ShowGridMenu, AddressOf Vista_ShowGridMenu
                Else
                    If ControlL.Controls.Count > 0 Then
                        PrepararPersonalizacion(ControlL)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PersonalizarCampo()
        Try
            Dim dtCampo As DataTable = STIConn.ObtenerDataset("select * from VistasCampos where forma = " & dbStr(Me.Name)).Tables(0)
            Dim Control As Object
            For Each FilCampo As DataRow In dtCampo.Rows
                Try
                    Control = Me.Controls.Find(dbData(FilCampo, "campo"), True)(0)
                    If TypeOf Control Is STIControles.stiTextBox Or TypeOf Control Is STIControles.stiMemo Or TypeOf Control Is STIControles.stiComboBox Then
                        Control.LabelText = dbData(FilCampo, "Nombre")
                        If dbData(FilCampo, "Obligatorio") = "1" Then Control.Obligatorio = True
                        If dbData(FilCampo, "Obligatorio") = "0" Then Control.Obligatorio = False
                    End If
                    If TypeOf Control Is DevExpress.XtraEditors.LabelControl Or TypeOf Control Is Label Then
                        Control.Text = dbData(FilCampo, "Nombre")
                    End If
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub PersonalizarVistas(ByRef ControlL As System.Windows.Forms.Control)
        For Each ControlL1 As Object In ControlL.Controls
            Try
                If TypeOf ControlL1 Is STIControles.stiGrid Then
                    'ahora si han personalizado nombre de columnas
                    Dim dtPersonalizaCol As DataTable = Me.STIConn.ObtenerDataset("select campo, nombre from VistasCampos where forma = " & dbStr(Me.Name) & " and campo like " & dbStr(ControlL1.Views(0).Name & ".%")).Tables(0)
                    For Each FilCol As DataRow In dtPersonalizaCol.Rows
                        ControlL1.Views(0).Columns(stiSplit(dbData(FilCol, "campo"), "G1.1")).Caption = dbData(FilCol, "nombre")
                    Next
                End If
            Catch ex As Exception

            End Try

            If ControlL1.Controls.Count > 0 Then
                PersonalizarVistas(ControlL1)
            End If
        Next
    End Sub

    Private Sub Vista_ShowGridMenu(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs)
        If STIConn.UsuarioPerteneceAGrupo(STIConn.User, "ADMINISTRADORES") = True Then
            If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
                Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = CType(e.Menu, DevExpress.XtraGrid.Menu.GridViewColumnMenu)
                If Not menu.Column Is Nothing Then
                    ColumnaMenu = menu.Column

                    menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Personalizar Columna", New EventHandler(AddressOf PersonalizarColumnaGrid), Nothing))
                End If
            End If
        End If
    End Sub

    Dim ColumnaMenu As DevExpress.XtraGrid.Columns.GridColumn

    Private Sub PersonalizarColumnaGrid()
        Dim FrmPerCampo As New stiPersonalizaCampo
        FrmPerCampo.Forma = Me.Name
        FrmPerCampo.Campo = ColumnaMenu.View.Name & "." & ColumnaMenu.FieldName
        FrmPerCampo.Nombre = ColumnaMenu.Caption
        FrmPerCampo.STIConn = Me.STIConn
        FrmPerCampo.cboObligatorio.Visible = False
        FrmPerCampo.ShowDialog()
        Call PersonalizarVistas(Me)
    End Sub


#End Region

End Class