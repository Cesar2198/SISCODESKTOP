Imports System.ComponentModel
Imports Utilerias.Genericas

Public Class stiNavegador

    Public STIConn As Conectividad.Funciones
    Private Datos As DataSet
    Public Event AntesLanzarFormularioNuevo(ByRef FormularioEdicion As Object)
    Public Event AntesDeCargarRegistros()
    Public Event DespuesDeCargarRegistros()
    Public Event ComplementarDatosGrid(ByRef Datos As DataSet)
    Public Event VistaNavClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event VistaNavCustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
    Private FilaSel As Integer

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

    Private FormularioEdicionL As String = ""
    <Category("Administración Formularios"), Description("Indica el nombre del formulario de mantenimiento")> _
    Public Property FormularioEdicion() As String
        Get
            Return FormularioEdicionL
        End Get
        Set(ByVal value As String)
            FormularioEdicionL = value
        End Set
    End Property

    Private ListaCamposL As String = ""
    <Category("Administración Formularios"), Description("Indica la lita de campos a mostrarse en el grid (campos select del query)")> _
    Public Property ListaCampos() As String
        Get
            Return ListaCamposL
        End Get
        Set(ByVal value As String)
            ListaCamposL = value
        End Set
    End Property

    Private ListaAliasCamposL As String = ""
    <Category("Administración Formularios"), Description("Indica los alias que se le desean dar a los campos (Opcional)")> _
    Public Property ListaAliasCampos() As String
        Get
            Return ListaAliasCamposL
        End Get
        Set(ByVal value As String)
            ListaAliasCamposL = value
        End Set
    End Property

    Private OrdenRegistrosL As String
    <Category("Administración Formularios"), Description("Indica la lista de campos como se desean ordenar los registros (campos order by de un query)")> _
    Public Property OrdenRegistros() As String
        Get
            Return OrdenRegistrosL
        End Get
        Set(ByVal value As String)
            OrdenRegistrosL = value
        End Set
    End Property

    Private dbTabla As String = ""
    <Category("Administración Formularios"), Description("Indica el nombre de la tabla de la base de datos que se navegara")> _
    Public Property Tabla() As String
        Get
            Return dbTabla
        End Get
        Set(ByVal value As String)
            dbTabla = value
        End Set
    End Property

    Private dbFiltro as string = ""
    <Category("Administración Formularios"), Description("Indica el filtro de registros")> _
    Public Property Filtro() As String
        Get
            Return dbFiltro
        End Get
        Set(ByVal value As String)
            dbFiltro = value
        End Set
    End Property

    Private dbSQlManual As String = ""
    <Category("Administración Formularios"), Description("Indica un query complejo para la consulta de registros")> _
    Public Property SQlManual() As String
        Get
            Return dbSQlManual
        End Get
        Set(ByVal value As String)
            dbSQlManual = value
        End Set
    End Property

    private ListaCamposOcultosL as string = ""
    <Category("Administración Formularios"), Description("Indica la lista de los campos que se ocultarna, basados en la lista de campos proporcionada, se reconocen mayúsculas y minúsculas")> _
    public Property ListaCamposOcultos as string
        Get
            return ListaCamposOcultosL
        End Get
        Set(ByVal value As String)
            ListaCamposOcultosL = value
        End Set
    End Property

    Private ListaCamposLlaveL As String = ""
    <Category("Administración Formularios"), Description("Indica la lista de los campos que son llaves y que son pasados a los formularios de edición.")> _
    Public Property ListaCamposLlave() As String
        Get
            Return ListaCamposLlaveL
        End Get
        Set(ByVal value As String)
            ListaCamposLlaveL = value
        End Set
    End Property

    Private CargarRegistrosAlAbrirL As Boolean = True
    <Category("Administración Formularios"), Description("Indica si en el Load del formulario se cargaran los registros.")> _
    Public Property CargarRegistrosAlAbrir() As Boolean
        Get
            Return CargarRegistrosAlAbrirL
        End Get
        Set(ByVal value As Boolean)
            CargarRegistrosAlAbrirL = value
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            If FormularioEdicionL = "" Then
                Exit Sub
            End If

            Dim tempAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetEntryAssembly()
            Dim frmNuevo As Object = CType(tempAssembly.CreateInstance(stiSplit(tempAssembly.FullName, "G0,1").Trim & "." & FormularioEdicionL), System.Windows.Forms.Form)

            frmNuevo.dbTabla = Me.dbTabla
            frmNuevo.STIConn = Me.STIConn
            frmNuevo.Permiso = Me.PermisoL
            'por si se necesita incluir informacion adicional al formulario
            RaiseEvent AntesLanzarFormularioNuevo(frmNuevo)
            If ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
                frmNuevo.MdiParent = Me.MdiParent
                frmNuevo.Show()
            Else
                frmNuevo.ShowDialog()
                'actualizamos los registros
                Try
                    If frmNuevo.blnCambiosRealizados = True Then
                        Call CargarRegistros()
                    End If
                Catch ex As Exception

                End Try
            End If

        Catch ex As Exception
            'no controlaremos el error
        End Try
    End Sub

    Private Sub stiNavegador_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
            'Call CargarRegistros()
        End If

    End Sub

    Private Sub stiNavegador_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim RecordarVista As String = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Vistas'").Tables(0).Rows(0).Item(0)
            If RecordarVista.Trim.ToUpper = "S" Then
                AlmacenarVistas(Me)
            End If
        Catch ex As Exception

        End Try

        Try
            Me.Datos.Clear()
            Me.Datos = Nothing
            GC.ReRegisterForFinalize(Datos)
            Me.Datos.Dispose()
            Me.GridNav.Dispose()
            GC.Collect()
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub stiNavegador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.EsModoDisenio = False Then
            If Me.CargarRegistrosAlAbrirL = True Then Call CargarRegistros()
            Call ValidarPermiso()

        End If
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

    Private Sub ValidarPermiso()
        Select Case Me.PermisoL
            Case "L"
                'solo lectura deshabilitamos
                Me.btnEliminar.Enabled = False
                Me.btnNuevo.Enabled = False
                Call DeshabilitarBotonesExtra(Me)
            Case "I"
                'solo lectura sin impresión deshabilitamos
                Me.btnEliminar.Enabled = False
                Me.btnNuevo.Enabled = False
                Me.btnImprimir.Enabled = False
                Call DeshabilitarBotonesExtra(Me)
            Case "W"
                Me.btnEliminar.Enabled = False
        End Select

    End Sub

    Public Sub CargarRegistros()
        Try
            'para recordar los filtros del nav.
            Dim Filtro(VistaNav.Columns.Count) As String
            For NC As Integer = 0 To Filtro.Length - 1
                Try
                    Filtro(NC) = VistaNav.GetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, VistaNav.Columns(NC).FieldName)
                Catch ex As Exception
                    Filtro(NC) = ""
                End Try
            Next

            RaiseEvent AntesDeCargarRegistros()

            Me.Cursor = Windows.Forms.Cursors.WaitCursor
            Dim sql As String = ""
            sql = "select " & ListaCamposL & " from " & Me.dbTabla
            If dbFiltro <> "" Then
                sql &= " where " & dbFiltro
            End If

            If OrdenRegistrosL <> "" Then
                sql &= " order by " & OrdenRegistrosL
            End If

            If SQlManual <> "" Then sql = SQlManual

            Datos = Me.STIConn.ObtenerDataset(sql)

            'para complementar datos calculados con la tabla que se obtiene
            RaiseEvent ComplementarDatosGrid(Datos)

            Me.GridNav.DataSource = Datos.Tables(0)

            Try
                'ahora si hay alias validamos
                If Me.ListaAliasCamposL <> "" Then
                    Dim NumCol As Integer = CuentaCar(Me.ListaAliasCamposL, ","), ColNombre As String = ""
                    For i As Integer = 0 To NumCol
                        ColNombre = stiSplit(Me.ListaAliasCamposL, "G" & i & ",1").Trim
                        If ColNombre <> "" Then
                            Me.VistaNav.Columns(i).Caption = ColNombre
                        End If
                        ' ''los campos llaves los ordenaremos como número
                        ''If InStr(Me.ListaCamposLlave, Me.VistaNav.Columns(i).FieldName) > 0 Then
                        ''    Me.VistaNav.Columns(i).SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
                        ''End If
                    Next
                End If
            Catch ex As Exception

            End Try

            Call PersonalizarColumnas()

            Try
                'ahora si hay campos que ocultar
                If ListaCamposOcultosL.Trim <> "" Then
                    Dim NumCol As Integer = CuentaCar(Me.ListaCamposOcultosL, ","), ColNombre As String = ""
                    For i As Integer = 0 To NumCol
                        ColNombre = stiSplit(Me.ListaCamposOcultos, "G" & i & ",1").Trim
                        If ColNombre <> "" Then
                            Try
                                Me.VistaNav.Columns(ColNombre).Visible = False
                            Catch ex As Exception

                            End Try
                        End If
                    Next
                End If
            Catch ex As Exception

            End Try

            'varificaremos si las vistas de grid están almacenadas.
            Try
                Dim RecordarVista As String = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Vistas'").Tables(0).Rows(0).Item(0)
                If RecordarVista.Trim.ToUpper = "S" Then
                    PrepararVistas(Me)
                End If
            Catch ex As Exception

            End Try

            RaiseEvent DespuesDeCargarRegistros()

            Try
                'regresamos los filtros escritos
                For NC As Integer = 0 To Filtro.Length - 1
                    Try
                        If Filtro(NC) <> "" Then
                            VistaNav.SetRowCellValue(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle, VistaNav.Columns(NC).FieldName, Filtro(NC))
                        End If
                    Catch ex As Exception

                    End Try
                Next
            Catch ex As Exception

            End Try


            Try
                Me.lblStatus.Text = "Num.Registros: " & Datos.Tables(0).Rows.Count
            Catch ex As Exception

            End Try

            Me.Cursor = Windows.Forms.Cursors.Default
            Me.GridNav.Refresh()
            'Me.GridNav.EstablecerTipoFiltro(DevExpress.XtraGrid.Columns.FilterPopupMode.Default)
            Try
                'tratamos de marcar la misma fila que se selecionó al principio
                Me.VistaNav.FocusedRowHandle = FilaSel
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MsgBox("Error al cargar los registros." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")

        End Try
    End Sub

    Private Function CuentaCar(ByVal Cadena As String, ByVal CAR As String) As Integer
        'esta funcion devuelve la cantidad de caracteres encontrados en
        'una cadena.

        Dim Cont As Long, ULT As Integer
        Cont = 0 : ULT = 1
        Do While 1
            ULT = InStr(ULT, Cadena, CAR)
            If ULT <> 0 Then
                ULT = ULT + 1 : Cont = Cont + 1
            Else
                Exit Do
            End If
        Loop
        Return Cont
    End Function

    Private Function stiSplit(ByVal ID As String, ByVal Param As String) As String
        'EL PARAM ES G#?# es usado para calcular substring especiales, separados por 
        'un caracter especial.

        Dim Car As String = "", INICIO As Integer, ITEMS As Integer, I As Long
        Dim INI As Integer, FIN As Integer, ITEMT As Integer, ITEMC As Integer
        Dim TOTITEMS As Integer

        Select Case Param.ToUpper.Substring(0, 1)
            Case "G"
                For I = 1 To Param.Length - 1
                    If Not IsNumeric(Param.Substring(I, 1)) Then
                        INICIO = Val(Param.Substring(1, I - 1))
                        ITEMS = Val(Param.Substring(I + 1, Param.Length - (I + 1)))
                        Car = Param.Substring(I, 1)
                        Exit For
                    End If
                Next
                TOTITEMS = CuentaCar(ID, Car)
                ITEMT = 0 : INI = 0 : ITEMC = -1
                If TOTITEMS = 0 Then
                    'NO EXISTEN CARATERES ESPECIALES, SE REGRESA TODO EL TEXTO
                    Return ID
                Else
                    For I = 0 To ID.Length - 1
                        If ID.Substring(I, 1) = Car Or I = ID.Length Then
                            If ITEMT <> INICIO Then
                                If ITEMC = -1 Then INI = I + 1
                            Else
                                ITEMC = 0
                            End If
                            If ITEMC >= 0 Then ITEMC = ITEMC + 1
                            If ITEMC = ITEMS Then
                                FIN = I - 1
                                Exit For
                            End If
                            ITEMT = ITEMT + 1
                        End If
                    Next
                    If ITEMT = INICIO Then ITEMC = 0
                    If ITEMC = -1 Then
                        Return ""
                    Else
                        If FIN = 0 And I = ID.Length Then FIN = ID.Length - 1
                        Return ID.Substring(INI, (FIN - INI) + 1)
                    End If
                End If
        End Select

        'si llega hasta aqui el formato esta mal mandamos vacio
        Return ""
    End Function

    Public Overridable Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If Me.VistaNav.FocusedRowHandle < 0 Or FormularioEdicionL = "" Then
                'no se ha selecionado registro, puede ser un grupo, no hacemos nada
                Exit Sub
            End If

            FilaSel = Me.VistaNav.FocusedRowHandle
            Dim tempAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetEntryAssembly()
            Dim frmMod As Object = CType(tempAssembly.CreateInstance(stiSplit(tempAssembly.FullName, "G0,1").Trim & "." & FormularioEdicionL), System.Windows.Forms.Form)
            frmMod.dbTabla = Me.dbTabla
            frmMod.STIConn = Me.STIConn
            frmMod.Permiso = Me.PermisoL
            frmMod.dbCondicion = ObtenerLlaveRegistro()
            'frmMod.MdiParent = Me
            If sender Is btnEliminar Then
                frmMod.AbrirEnEstadoEliminacion = True
            End If
            If ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
                frmMod.MdiParent = Me.MdiParent
                frmMod.Show()
            Else
                frmMod.ShowDialog()
                'actualizamos los registros
                Try
                    If frmMod.blnCambiosRealizados = True Then
                        Call CargarRegistros()
                    End If
                Catch ex As Exception

                End Try
            End If

        Catch ex As Exception
            'no controlaremos el error
            msgError(ex)
        End Try
    End Sub

    Private Function ObtenerLlaveRegistro() As String
        Dim res As String = ""
        Try
            If ListaCamposLlaveL = "" Then
                MsgBox("No se han definido campos llave para editar registros.", MsgBoxStyle.Exclamation, "AVISO...")
            Else
                Dim Col As DevExpress.XtraGrid.Columns.GridColumn, NomCol As String = ""
                Dim NumLlaves As Integer = CuentaCar(ListaCamposLlaveL, ",")
                For NL As Integer = 0 To NumLlaves
                    NomCol = stiSplit(ListaCamposLlaveL, "G" & NL & ",1").Trim
                    If NomCol <> "" Then
                        Try
                            Col = Me.VistaNav.Columns(NomCol)
                            Dim Tipo As String = Col.ColumnType.Name.ToLower
                            If Tipo Like "*int*" Or Tipo Like "*long*" Or Tipo Like "*nume*" Or Tipo Like "*deci*" Or Tipo Like "*float*" Or Tipo Like "*curre*" Or Tipo Like "*money*" Then
                                res &= " and " & Col.FieldName & " = " & dbNum(VistaNav.GetRowCellValue(Me.VistaNav.FocusedRowHandle, Col.FieldName))
                            ElseIf Tipo Like "*string*" Or Tipo Like "*char*" Or Tipo Like "*text*" Or Tipo Like "*memo*" Then
                                res &= " and " & Col.FieldName & " = " & dbStr(VistaNav.GetRowCellValue(Me.VistaNav.FocusedRowHandle, Col.FieldName))
                            ElseIf Tipo Like "*date*" Then
                                res &= " and " & Col.FieldName & " = " & dbFec(VistaNav.GetRowCellValue(Me.VistaNav.FocusedRowHandle, Col.FieldName))
                            End If
                        Catch ex As Exception

                        End Try
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
        If res <> "" Then res = res.Substring(5)
        Return res
    End Function

    Private Sub GridNav_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridNav.DoubleClick
        Call btnModificar_Click(btnModificar, New System.EventArgs)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Call btnModificar_Click(btnEliminar, New System.EventArgs)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim SubKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
            Dim Archivo As String = SubKey.GetValue("Personal") & "\Reporte" & Me.Name & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridNav.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Generación del Reporte: " & Me.STIConn.User & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "", ObtenerDBParametros("Password.Documentos"))
            'AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Public Function ObtenerDBParametros(ByVal IdParametro As String) As Object
        Dim Res As Object = Nothing
        Try
            Dim FilPar As DataRow = Me.STIConn.ObtenerDataset("select * from Parametros where idparametro = " & dbStr(IdParametro)).Tables(0).Rows(0)
            Select Case dbData(FilPar, "Tipo").Trim.ToUpper
                Case "N"
                    Res = CDbl(dbData(FilPar, "Valor"))
                Case "T"
                    Res = CStr(dbData(FilPar, "Cadena"))
                Case "E"
                    Res = CInt(dbData(FilPar, "Entero"))
                Case "F"
                    Res = CDate(dbData(FilPar, "Fecha"))
            End Select
        Catch ex As Exception
            Res = Nothing
        End Try
        Return Res
    End Function

    'Private Sub PrepararArchivoExcel(ByVal fileName As String, ByVal Titulo1 As String, ByVal Titulo2 As String, ByVal Titulo3 As String)

    '    Try
    '        Dim Miexcel As Object, Hoja As Object
    '        Miexcel = CreateObject("Excel.Application")
    '        Miexcel.Workbooks.Open(fileName)
    '        Hoja = Miexcel.Worksheets(1)

    '        'insertamos 5 filas al inicio
    '        Hoja.Range("A1").Select()
    '        Miexcel.Selection.EntireRow.Insert()
    '        Hoja.Range("A1").Select()
    '        Miexcel.Selection.EntireRow.Insert()
    '        Hoja.Range("A1").Select()
    '        Miexcel.Selection.EntireRow.Insert()
    '        Hoja.Range("A1").Select()
    '        Miexcel.Selection.EntireRow.Insert()
    '        Hoja.Range("A1").Select()
    '        Miexcel.Selection.EntireRow.Insert()


    '        Hoja.Cells(1, 1).Value = ""
    '        Hoja.Cells(2, 1).Value = Titulo1
    '        Hoja.Cells(3, 1).Value = Titulo2
    '        Hoja.Cells(4, 1).Value = Titulo3

    '        Hoja.Rows("1:4").Select()
    '        Miexcel.Selection.Font.Bold = True
    '        Hoja.Range("A1").Select()

    '        Miexcel.Workbooks(1).Save()
    '        Miexcel.Visible = True
    '        Miexcel = Nothing
    '        Hoja = Nothing

    '    Catch ex As Exception
    '        MsgBox("Error al preparar el reporte en Excel." & vbCrLf & fileName & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
    '    End Try
    'End Sub

    Private Sub AbrirArchivo(ByVal fileName As String, Optional ByVal Verbo As String = "Open")
        Try
            Dim process As System.Diagnostics.Process = New System.Diagnostics.Process
            process.StartInfo.FileName = fileName
            process.StartInfo.Verb = Verbo
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            process.Start()
        Catch
            MsgBox("No se puede abrir el archivo: " & fileName, MsgBoxStyle.Information, "AVISO...")
        End Try
    End Sub

    Private Sub GridNav_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridNav.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Call btnModificar_Click(btnModificar, New System.EventArgs)
        End If
    End Sub

    Private Function EsModoDisenio() As Boolean
        Dim Res As Boolean
        Try
            If Not Me.Site Is Nothing And Me.Site.DesignMode = True Then
                Res = True
            Else
                Res = False
            End If
        Catch ex As Exception
            Res = False
        End Try
        Return Res
    End Function

    Private Sub VistaNav_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaNav.Click
        'lanzaremos el evento sobre el formulario
        Try
            RaiseEvent VistaNavClick(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaNav_ColumnFilterChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaNav.ColumnFilterChanged
        Try
            Me.lblStatus.Text = "Num.Registros: " & VistaNav.RowCount
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeshabilitarBotonesExtra(ByRef Control As System.Windows.Forms.Control)
        'existen formularios que puede tener botones extra, en modo lectura estos deben estas deshabilitados
        Try
            For Each ControlL In Control.Controls
                If TypeOf ControlL Is DevExpress.XtraEditors.SimpleButton Or TypeOf ControlL Is System.Windows.Forms.Button Then
                    Select Case ControlL.Name.Trim
                        Case "btnNuevo", "btnEliminar", "btnAyuda", "btnSalir", "btnModificar"
                            'los botones locales no los tocamos
                        Case Else
                            ControlL.Enabled = False
                    End Select
                Else
                    If ControlL.Controls.Count > 0 And Not (TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiGrid Or TypeOf ControlL Is STIControles.stiMemo) Then
                        DeshabilitarBotonesExtra(ControlL)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        Call funLanzarAyuda(Me, AyudaId)
    End Sub

    Private Sub VistaNav_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles VistaNav.CustomColumnDisplayText
        'lanzaremos el evento sobre el formulario
        Try
            RaiseEvent VistaNavCustomColumnDisplayText(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaNav_CustomColumnSort(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs) Handles VistaNav.CustomColumnSort
        Try
            If e.Value1 Is Nothing OrElse e.Value2 Is Nothing Then
                Return
            End If
            If e.Column.SortMode <> DevExpress.XtraGrid.ColumnSortMode.Custom Then Exit Sub

            e.Handled = True

            Dim s1 As Double = 0, S2 As Double = 0

            s1 = OrdenComoNumero(e.Value1.ToString())
            S2 = OrdenComoNumero(e.Value2.ToString())

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

    Private Function OrdenComoNumero(ByVal Elemento As String) As Double
        Dim Orden As Double = 0
        If IsNumeric(Elemento) Then
            Orden = CDbl(Elemento)
        Else
            Orden = Elemento.GetHashCode
        End If
        Return Orden
    End Function

    Private Sub VistaNav_ShowGridMenu(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs) Handles VistaNav.ShowGridMenu
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
        FrmPerCampo.Campo = VistaNav.Name & "." & ColumnaMenu.FieldName
        FrmPerCampo.Nombre = ColumnaMenu.Caption
        FrmPerCampo.STIConn = Me.STIConn
        FrmPerCampo.cboObligatorio.Visible = False
        FrmPerCampo.ShowDialog()
        Call PersonalizarColumnas()
    End Sub

    Private Sub PersonalizarColumnas()
        Try
            'ahora si han personalizado nombre de columnas
            Dim dtPersonalizaCol As DataTable = Me.STIConn.ObtenerDataset("select campo, nombre from VistasCampos where forma = " & dbStr(Me.Name) & " and campo like " & dbStr(VistaNav.Name & ".%")).Tables(0)
            For Each FilCol As DataRow In dtPersonalizaCol.Rows
                Me.VistaNav.Columns(stiSplit(dbData(FilCol, "campo"), "G1.1")).Caption = dbData(FilCol, "nombre")
            Next
        Catch ex As Exception

        End Try
    End Sub

End Class