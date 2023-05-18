Imports System.ComponentModel

<ToolboxBitmap("combo.ico"), DefaultEvent("ValueChangeOnExit")> _
Public Class stiComboBox

#Region "Declaraciones"

    Public Enum TipoContenido
        Texto = 1
        Numero = 2
        Fecha = 3
    End Enum

    Public Enum LOrientacion
        Izquierda = 1
        Superior = 2
    End Enum

    Private PresionaESC As Boolean = False
    Private AjustandoTamanio As Boolean = False
    Private dtCombo As New DataTable
    Private Valor1 As String = ""
    Public HabilitarEvento As Boolean = True

    Public Event ValueChangeOnExit(ByVal sender As Object, ByVal e As System.EventArgs, ByVal ValorAnterior As String)
    Public Event NewItem(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

#End Region

#Region "Eventos"
    Private Sub stiComboBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Try
            Me.cboControl.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub stiComboBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If AjustandoTamanio = True Then Exit Sub
        Call AjustarTamanio()
    End Sub

    Private Sub stiComboBox_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If AjustandoTamanio = True Then Exit Sub
        Call AjustarTamanio()
    End Sub

    Private Sub cboControl_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboControl.EditValueChanged
        If CStr(Me.Valor) = Me.TextoNuevoItemL And Me.TextoNuevoItemL <> "" And HabilitarEvento = True Then
            RaiseEvent NewItem(cboControl, New System.EventArgs)
        Else
            Try
                RaiseEvent EditValueChanged(sender, e)
                If Not Me.ParentForm Is Nothing Then
                    Me.ParentForm.SelectNextControl(Me, True, True, True, True)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cboControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboControl.GotFocus
        Valor1 = Me.Text
    End Sub

    Private Sub cboControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboControl.KeyDown
        If e.KeyCode = Keys.Escape Then
            PresionaESC = True
            Me.ParentForm.SelectNextControl(Me, True, True, True, True)
            Exit Sub
        Else
            PresionaESC = False
            If e.KeyCode = Keys.Delete Then
                Me.cboControl.EditValue = Nothing
                Me.cboControl.Text = ""
                Me.Valor = ""
            End If
        End If

        'If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
        '    cboControl.EditValue = Nothing
        '    Exit Sub
        'End If

        'If cboControl.IsPopupOpen = False And e.KeyCode <> Keys.Enter Then cboControl.ShowPopup()

    End Sub

    Private Sub cboControl_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboControl.Validating

        If Valor1 <> Me.Text And HabilitarEvento = True Then
            Try
                'intentamos indicarle al formulario que se modifico un dato.
                If CType(Me.FindForm, Object).blnCargandoRegistro = False Then
                    CType(Me.ParentForm, Object).blnRegistroModificado = True
                End If

            Catch ex As Exception

            End Try
            RaiseEvent ValueChangeOnExit(sender, New System.EventArgs, Valor1)
        End If

        If Me.Obligatorio = True And Me.cboControl.Text = "" And Me.SoloLectura = False Then
            If PresionaESC = False Then
                'e.Cancel = True
            End If
            Call RegistrarError("El campo es obligatorio.")
            Exit Sub
        End If

        'si llegamos hasta aqui no hay error...
        Call RegistrarError("")
        

    End Sub

#End Region

#Region "Propiedades"

    <Category("Administración Formularios"), Description("Inidica si se muestra el Auto Filter Row")> _
    Public Property MostrarBusquedaColumnas() As Boolean
        Get
            Return cboControl.Properties.View.OptionsView.ShowAutoFilterRow
        End Get
        Set(ByVal value As Boolean)
            cboControl.Properties.View.OptionsView.ShowAutoFilterRow = value
        End Set
    End Property

    <Category("Administración Formularios"), Description("Número de filas visibles")> _
    Public Property FilasVisibles() As Integer
        Get
            'Return Me.cboControl.Properties.DropDownRows
            Try
                Return CInt(Me.cboControl.Properties.PopupFormSize.Height / 20)
            Catch ex As Exception

            End Try

        End Get
        Set(ByVal value As Integer)
            'Me.cboControl.Properties.DropDownRows = value
            Try
                Me.cboControl.Properties.PopupFormSize = New System.Drawing.Size(Me.Width * 1.6, value * 20 * 1.6)
            Catch ex As Exception

            End Try

        End Set
    End Property

    <Category("Administración Formularios"), Description("Color del fondo del control")> _
    Public Property ControlBackColor() As System.Drawing.Color
        Get
            Return Me.cboControl.BackColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            Me.cboControl.BackColor = value
        End Set
    End Property

    <Category("Administración Formularios"), Description("Color del texto del control")> _
    Public Property ControlForeColor() As System.Drawing.Color
        Get
            Return Me.cboControl.ForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            Me.cboControl.ForeColor = value
        End Set
    End Property

    Private LabelWidthL As Integer = 100
    <Category("Administración Formularios"), Description("Indica el ancho de la etiqueta")> _
    Public Property LabelWidth() As Integer
        Get
            Return LabelWidthL
        End Get
        Set(ByVal value As Integer)
            LabelWidthL = value
            Call AjustarTamanio()
        End Set
    End Property

    <Category("Administración Formularios"), Description("Indica el texto de la etiqueta del control")> _
    Public Property LabelText() As String
        Get
            Return Me.lblControl.Text
        End Get
        Set(ByVal value As String)
            Me.lblControl.Text = value
        End Set
    End Property

    Private LabelOrientationL As LOrientacion = LOrientacion.Izquierda
    <Category("Administración Formularios"), Description("Indica la posición de la etiqueta")> _
    Public Property LabelOrietation() As LOrientacion
        Get
            Return LabelOrientationL
        End Get
        Set(ByVal value As LOrientacion)
            LabelOrientationL = value
            Call AjustarTamanio()
        End Set
    End Property

    <Category("Administración Formularios"), Description("Establece o devuelve el contenido del control")> _
    Public Property Valor() As Object
        Get
            Dim result As Object = Nothing
            Try
                If Not cboControl.EditValue Is Nothing Then
                    Select Case TipoL
                        Case TipoContenido.Texto
                            result = CStr(cboControl.EditValue)
                        Case TipoContenido.Numero
                            result = CDbl(Replace(Replace(cboControl.EditValue, ",", ""), "$", ""))
                        Case TipoContenido.Fecha
                            result = CDate(cboControl.EditValue)
                    End Select
                End If
            Catch ex As Exception
                'no controlamos el error
            End Try
            Return result
        End Get
        Set(ByVal value As Object)
            Try
                If CStr(value) = "" Then
                    cboControl.EditValue = ""
                Else
                    If Not value Is Nothing Then
                        Dim Tipo As String = ""
                        Try
                            Tipo = dtCombo.Columns(CampoValorL).DataType.Name.ToLower()
                        Catch ex As Exception
                            Tipo = "string"
                        End Try
                        If Tipo Like "*int*" Or Tipo Like "*long*" Then
                            Me.cboControl.EditValue = CInt(value)
                        ElseIf Tipo Like "*string*" Or Tipo Like "*char*" Or Tipo Like "*text*" Or Tipo Like "*memo*" Then
                            Me.cboControl.EditValue = CStr(value)
                        ElseIf Tipo Like "*nume*" Or Tipo Like "*deci*" Or Tipo Like "*float*" Or Tipo Like "*curre*" Or Tipo Like "*money*" Then
                            Me.cboControl.EditValue = CDbl(Replace(Replace(value, ",", ""), "$", ""))
                        ElseIf Tipo Like "*date*" Then
                            Me.cboControl.EditValue = CDate(value)
                        End If

                        Me.cboControl.Refresh()
                    End If

                End If


                RegistrarError("")
            Catch ex As Exception

            End Try
        End Set
    End Property

    Public ReadOnly Property Descripcion() As String
        Get
            Try
                Return cboControl.Text
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property

    Private CampoL As String = ""
    <Category("Administración Formularios"), Description("Especifica el nombre del campo de la base de datos")> _
    Public Property NombreCampo() As String
        Get
            Return CampoL
        End Get
        Set(ByVal value As String)
            CampoL = value
        End Set
    End Property

    Private CampollaveL As Boolean = False
    <Category("Administración Formularios"), Description("Indica si el campo es una llave de la tabla")> _
    Public Property CampoEsLlave() As Boolean
        Get
            Return CampollaveL
        End Get
        Set(ByVal value As Boolean)
            CampollaveL = value
        End Set
    End Property

    Private CampoBusquedaL As Boolean = False
    <Category("Administración Formularios"), Description("Indica si el campo es usado para la búsqueda de registros")> _
    Public Property CampoBusqueda() As Boolean
        Get
            Return CampoBusquedaL
        End Get
        Set(ByVal value As Boolean)
            CampoBusquedaL = value
        End Set
    End Property

    Private ObligatorioL As Boolean = False
    <Category("Administración Formularios"), Description("Indica si el campo es obligatorio")> _
    Public Property Obligatorio() As Boolean
        Get
            Return ObligatorioL
        End Get
        Set(ByVal value As Boolean)
            ObligatorioL = value
            If ObligatorioL = True Then
                Me.lblControl.Font = New Font(cboControl.Font, FontStyle.Bold)
            Else
                Me.lblControl.Font = New Font(cboControl.Font, FontStyle.Regular)
            End If
        End Set
    End Property

    Private SoloLecturaL As Boolean = False
    <Category("Administración Formularios"), Description("Indica si el control es de solo lectura")> _
    Public Property SoloLectura() As Boolean
        Get
            Return SoloLecturaL
        End Get
        Set(ByVal value As Boolean)
            SoloLecturaL = value
            Me.cboControl.Properties.ReadOnly = value
            'POR SI AL CONTROL SE LE DA UN COLOR ESPECIAL
            If Me.ControlBackColor = Color.White Or Me.ControlBackColor = Color.Gainsboro Then
                If value = True Then
                    Me.ControlBackColor = Color.Gainsboro
                Else
                    Me.ControlBackColor = Color.White
                End If
            End If
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return CStr(Me.Valor)
        End Get
        Set(ByVal value As String)
            Try
                Me.Valor = value
            Catch ex As Exception

            End Try
        End Set
    End Property

    <Category("Administración Formularios"), Description("Indica si el contenido de texto será mostrado en mayúsculas o minúsculas")> _
    Public Property CharacterCasing() As System.Windows.Forms.CharacterCasing
        Get
            Return Me.cboControl.Properties.CharacterCasing
        End Get
        Set(ByVal Value As System.Windows.Forms.CharacterCasing)
            Me.cboControl.Properties.CharacterCasing = Value
        End Set
    End Property

    Private TipoL As TipoContenido = TipoContenido.Texto
    <Category("Administración Formularios"), Description("Especifica el tipo de contenido del control")> _
    Public Property TipoDato() As TipoContenido
        Get
            Return TipoL
        End Get
        Set(ByVal value As TipoContenido)
            TipoL = value
        End Set
    End Property

    Private ListaL As String = ""
    <Category("Administración Formularios"), Description("Indica la lista manual de elementos, formato Id Descripción|Id Descripción...")> _
    Public Property Lista() As String
        Get
            Return ListaL
        End Get
        Set(ByVal value As String)
            ListaL = value
        End Set
    End Property

    Private QueryL As String = ""
    <Category("Administración Formularios"), Description("Indica la consulta SQL que llenará la lista de items, debe especificarse una conexion ")> _
    Public Property Query() As String
        Get
            Return QueryL
        End Get
        Set(ByVal value As String)
            QueryL = value
        End Set
    End Property

    Dim StringConectionL As String = ""
    <Category("Administración Formularios"), Description("Indica el objeto conexión a la base de datos")> _
    Public Property StringConection() As String
        Get
            Return StringConectionL
        End Get
        Set(ByVal value As String)
            StringConectionL = value
        End Set
    End Property

    Private TextoNuevoItemL As String = ""
    <Category("Administración Formularios"), Description("Indica el texto a mostrarse para el item que indique agregar un nuevo item y que lanzará el evento NuevoItem")> _
    Public Property TextoNuevoItem() As String
        Get
            Return TextoNuevoItemL
        End Get
        Set(ByVal Value As String)
            TextoNuevoItemL = Value
        End Set
    End Property

    Private CampoValorL As Integer = 0
    <Category("Administración Formularios"), Description("Indica cual de los datos mostrados es el que se devolverá como valor")> _
    Public Property CampoValor() As Integer
        Get
            Return CampoValorL
        End Get
        Set(ByVal value As Integer)
            CampoValorL = value
        End Set
    End Property

    Dim CampoDisplayL As Integer = 1
    <Category("Administración Formularios"), Description("Indica cual de los datos mostrados es el que se desplegará como principal")> _
    Public Property CampoDisplay() As Integer
        Get
            Return CampoDisplayL
        End Get
        Set(ByVal Value As Integer)
            CampoDisplayL = Value
        End Set
    End Property

    Dim CampoAutoCompletarL As Integer = 0
    <Category("Administración Formularios"), Description("Indica sobre cual campo se realizará la auto búsqueda y auto completar")> _
    Public Property CampoAutoCompletar() As Integer
        Get
            Return CampoAutoCompletarL
        End Get
        Set(ByVal Value As Integer)
            CampoAutoCompletarL = Value
        End Set
    End Property

    Public ReadOnly Property ItemCount() As Integer
        Get
            If TextoNuevoItemL <> "" Then
                Return CType(Me.cboControl.Properties.DataSource, DataTable).Rows.Count - 1
            Else
                Return CType(Me.cboControl.Properties.DataSource, DataTable).Rows.Count
            End If
        End Get
    End Property

    Public Property SelectIndex() As Integer
        Get
            'Return Me.cboControl.ItemIndex
            cboControl.Properties.GetIndexByKeyValue(cboControl.EditValue)
        End Get
        Set(ByVal value As Integer)
            'Me.cboControl.ItemIndex = value
            Dim keyValue As Object = cboControl.Properties.GetKeyValue(value)
            cboControl.EditValue = keyValue
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Sub Llenar_Combo()
        Call Llenar_Combo(Nothing)
    End Sub

    Public Sub Llenar_Combo(ByVal dtDatos As DataTable)
        dtCombo = New DataTable
        Try
            Dim Fila As DataRow
            If Not dtDatos Is Nothing Then dtCombo = dtDatos

            If Me.ListaL.Trim <> "" Then
                'el combo se llenará con una lista especificada manualmente
                'por defecto será Id y Descripción
                dtCombo.Columns.Add("ID", System.Type.GetType("System.String"))
                dtCombo.Columns.Add("DESCRIPCION", System.Type.GetType("System.String"))
                Dim NumItems As Integer = CuentaCar(Me.ListaL, "|"), Item As String, Id As String = "", Descripcion As String = ""

                If TextoNuevoItemL <> "" Then
                    Fila = dtCombo.NewRow
                    Fila("ID") = TextoNuevoItemL
                    Fila("DESCRIPCION") = ""
                    dtCombo.Rows.Add(Fila)
                End If

                For i As Integer = 0 To NumItems
                    Item = stiSplit(Me.ListaL, "G" & i & "|1")
                    Id = stiSplit(Item, "G0 1")
                    Descripcion = stiSplit(Item, "G1 99")
                    Fila = dtCombo.NewRow
                    Fila("ID") = Id
                    Fila("DESCRIPCION") = Descripcion
                    dtCombo.Rows.Add(Fila)
                Next
                dtCombo.TableName = "Combo"
            Else
                'tenemos que tener una conexion y realizamos la consulta enviada.
                If QueryL <> "" And StringConectionL <> "" Then
                    'obtenemos los registros, utilizamos una conexion del tipo OleDb
                    Dim ds As DataSet = New DataSet()
                    Dim dbAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter(QueryL, StringConectionL)
                    dbAdapter.Fill(ds, "Combo")

                    If TextoNuevoItemL <> "" Then
                        Fila = ds.Tables(0).NewRow
                        Fila(0) = TextoNuevoItemL
                        ds.Tables(0).Rows.Add(Fila)
                    End If
                    dtCombo = ds.Tables(0)
                    dtCombo.TableName = "Combo"
                End If
            End If

            Try
                cboControl.Properties.View.Columns.Clear()
                cboControl.Properties.ValueMember = dtCombo.Columns(CampoValorL).ColumnName
                cboControl.Properties.DisplayMember = dtCombo.Columns(CampoDisplayL).ColumnName
                'cboControl.Properties.AutoSearchColumnIndex = CampoAutoCompletarL
            Catch ex As Exception

            End Try

            cboControl.Properties.DataSource = dtCombo
            'cboControl.Properties.PopulateColumns()

            Try
                For Each Col As DevExpress.XtraGrid.Columns.GridColumn In cboControl.Properties.View.Columns
                    Col.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
                Next
            Catch ex As Exception

            End Try

        Catch ex As Exception
            'no controlamos error...
            ''MsgBox(ex.Message & vbCrLf & StringConectionL, MsgBoxStyle.Critical, "Error llenar combo")
        End Try
    End Sub

    Public Sub OcultarColumna(ByVal Columna As Integer)
        Try
            'cboControl.Properties.Columns(Columna).Visible = False
            cboControl.Properties.View.Columns(Columna).Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Public Sub MostrarColumna(ByVal Columna As Integer)
        Try
            'cboControl.Properties.Columns(Columna).Visible = True
            cboControl.Properties.View.Columns(Columna).Visible = True

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Rutinas"

    Private Sub AjustarTamanio()
        Try
            AjustandoTamanio = True
            Select Case LabelOrietation
                Case LOrientacion.Izquierda
                    Me.SplitControl.Orientation = Orientation.Vertical
                    Me.SplitControl.SplitterDistance = LabelWidthL
                    If Me.Width < LabelWidthL + 15 Then
                        'Me.Width = LabelWidthL + 10
                        Me.Height = Me.cboControl.Height
                    Else
                        Me.Height = Me.cboControl.Height
                    End If
                    ''Me.SplitControl.Panel1MinSize = Me.LabelWidth

                Case LOrientacion.Superior
                    Me.Height = Me.cboControl.Height + Me.lblControl.Font.SizeInPoints + 10
                    Me.SplitControl.Orientation = Orientation.Horizontal
                    Me.SplitControl.SplitterDistance = Me.lblControl.Font.SizeInPoints + 10

            End Select
        Catch ex As Exception
            'no controlamos el error
        Finally
            AjustandoTamanio = False
        End Try
    End Sub

    Private Sub RegistrarError(ByVal Mensaje As String)
        If Mensaje = "" Then
            Me.ErrorProvider1.SetError(Me, "")
        Else
            Me.ErrorProvider1.SetError(Me, Mensaje)
        End If
    End Sub

#End Region



End Class
