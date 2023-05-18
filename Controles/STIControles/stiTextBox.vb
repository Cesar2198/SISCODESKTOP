Imports System.ComponentModel

<ToolboxBitmap("cajatexto.ico"), DefaultEvent("ValueChangeOnExit")> _
Public Class stiTextBox

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
    Private Valor1 As String = ""
    Public HabilitarEvento As Boolean = True


    Public Event ValueChangeOnExit(ByVal sender As Object, ByVal e As System.EventArgs, ByVal ValorAnterior As String)

#End Region

#Region "Eventos"

    Private Sub stiTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Try
            Me.txtControl.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub stiTextBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If AjustandoTamanio = True Then Exit Sub
        Call AjustarTamanio()
    End Sub

    Private Sub stiTextBox_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If AjustandoTamanio = True Then Exit Sub
        Call AjustarTamanio()
    End Sub

    Private Sub txtControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtControl.GotFocus
        'evitaremos que se seleccione texto
        Me.txtControl.SelectionLength = 0
        Valor1 = Me.Text
    End Sub

    Private Sub txtControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtControl.KeyDown
        If e.KeyCode = Keys.Escape Then
            PresionaESC = True
            Me.ParentForm.SelectNextControl(Me, True, True, True, True)
        Else
            PresionaESC = False
        End If
    End Sub

    Private Sub txtControl_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtControl.Validating

        If Me.FechaActual = True And Me.Obligatorio = True And Me.txtControl.Text = "" Then
            Me.Valor = Date.Today
        End If

        If Me.Obligatorio = True And Me.txtControl.Text = "" And Me.SoloLectura = False Then
            If PresionaESC = False Then
                'e.Cancel = True
            End If

            Call RegistrarError("El campo es obligatorio.")
            Exit Sub
        End If


        If Me.SoloLectura = True Then Exit Sub
        Try
            Select Case TipoDato
                Case TipoContenido.Fecha
                    Dim FEC As String
                    If Me.txtControl.Text = "" And Me.Obligatorio = False Then Exit Sub
                    FEC = ConvertirFecha(Me.txtControl.Text, Me.Formato)
                    If FEC = "" Then
                        RegistrarError("La fecha especificada es inválida.")
                        If Not PresionaESC Then e.Cancel = True
                        Exit Sub
                    Else
                        Me.Valor = CDate(FEC)
                    End If
                Case TipoContenido.Numero
                    Dim FormatoTemp As String = Me.Formato
                    If FormatoTemp = "" Then FormatoTemp = "#,###0.00"

                    If Me.txtControl.Text <> "" Then
                        If IsNumeric(Me.txtControl.Text) = True Then
                            Me.txtControl.Text = Format(CDbl(Me.txtControl.Text), FormatoTemp)
                        Else
                            Me.txtControl.Text = Format(CDbl(0), FormatoTemp)
                        End If

                    End If
                Case TipoContenido.Texto
                    'para que se pueda ver contenido largo
                    txtControl.ToolTip = txtControl.Text
            End Select
        Catch ex As Exception

        End Try

        'si llegamos hasta aqui no hay error...
        Call RegistrarError("")
    End Sub

    Private Sub btnFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFecha.Click
        If Me.SoloLecturaL = False Then
            Dim frmDate As New DropCalendario
            Dim dateL As Date
            Try
                dateL = CDate(Me.txtControl.Text)
            Catch ex As Exception
                dateL = Nothing
            End Try
            frmDate.Tag = dateL.ToString
            MostrandoCalendario = True

            frmDate.parentRectangle = Me.txtControl.RectangleToScreen(Me.txtControl.ClientRectangle)
            frmDate.Show(Me)
            While MostrandoCalendario = True
                Application.DoEvents()
            End While

            Dim ValAnt As String = Me.Text, ValNew As String = ""

            Try
                Me.txtControl.Focus()
                If Not frmDate.Tag Is Nothing Then
                    If IsDate(frmDate.Tag) Then
                        Me.Valor = frmDate.Tag
                        'Me.ParentForm.SelectNextControl(Me, True, True, True, True)
                        Me.txtControl.SelectionLength = 0
                        ValNew = Me.Text
                        If ValAnt <> ValNew And HabilitarEvento = True Then
                            Try
                                'intentamos indicarle al formulario que se modifico un dato.
                                If CType(Me.FindForm, Object).blnCargandoRegistro = False Then
                                    CType(Me.ParentForm, Object).blnRegistroModificado = True
                                End If

                            Catch ex As Exception

                            End Try
                            RaiseEvent ValueChangeOnExit(Me, New System.EventArgs, "")
                        End If
                    End If
                End If
                
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub stiTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
        'lanzamos un evento si cambio el contenido del control
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
    End Sub


#End Region

#Region "Propiedades"
    <Category("Administración Formularios"), Description("Color del fondo del control")> _
    Public Property ControlBackColor() As System.Drawing.Color
        Get
            Return Me.txtControl.BackColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            Me.txtControl.BackColor = value
        End Set
    End Property

    <Category("Administración Formularios"), Description("Color del texto del control")> _
    Public Property ControlForeColor() As System.Drawing.Color
        Get
            Return Me.txtControl.ForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            Me.txtControl.ForeColor = value
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

    Private FormatoL As String = ""
    <Category("Administración Formularios"), Description("Especifica el formto para Números y Fechas")> _
    Public Property Formato() As String
        Get
            Return FormatoL
        End Get
        Set(ByVal value As String)
            FormatoL = value
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
            Select Case TipoL
                Case TipoContenido.Fecha
                    btnFecha.Visible = True
                    Me.txtControl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                Case TipoContenido.Numero
                    btnFecha.Visible = False
                    Me.txtControl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                Case TipoContenido.Texto
                    btnFecha.Visible = False
                    Me.txtControl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            End Select
        End Set
    End Property

    <Category("Administración Formularios"), Description("Establece o devuelve el contenido del control")> _
    Public Property Valor() As Object
        Get
            Dim result As Object = Nothing
            Try

                Select Case TipoL
                    Case TipoContenido.Texto
                        result = txtControl.Text
                    Case TipoContenido.Numero
                        result = CDbl(Replace(Replace(txtControl.Text, ",", ""), "$", ""))
                    Case TipoContenido.Fecha
                        If txtControl.Text <> "" Then
                            result = CDate(txtControl.Text)
                        End If
                End Select

            Catch ex As Exception
                'no controlamos el error
            End Try
            Return result
        End Get
        Set(ByVal value As Object)
            Try
                If CStr(value) = "" Then
                    txtControl.Text = ""
                Else
                    Select Case TipoL
                        Case TipoContenido.Texto
                            txtControl.Text = CStr(value)
                            'para que se pueda ver contenido largo
                            txtControl.ToolTip = txtControl.Text
                        Case TipoContenido.Numero
                            If Formato.Trim <> "" Then
                                txtControl.Text = Format(CDbl(value), Formato)
                            Else
                                txtControl.Text = CDbl(value)
                            End If
                        Case TipoContenido.Fecha
                            If IsDate(value) Then
                                If Formato.Trim <> "" Then
                                    txtControl.Text = Format(CDate(value), Formato)
                                Else
                                    txtControl.Text = Format(CDate(value), "Long Date")
                                End If
                            End If
                    End Select
                End If
                RegistrarError("")
            Catch ex As Exception

            End Try
        End Set
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
                Me.lblControl.Font = New Font(txtControl.Font, FontStyle.Bold)
            Else
                Me.lblControl.Font = New Font(txtControl.Font, FontStyle.Regular)
            End If
        End Set
    End Property

    Private FechaActualL As Boolean = False
    <Category("Administración Formularios"), Description("Indica si se propondrá la fecha actual si el campo es obligatorio")> _
    Public Property FechaActual() As Boolean
        Get
            Return FechaActualL
        End Get
        Set(ByVal value As Boolean)
            FechaActualL = value
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
            Me.txtControl.Properties.ReadOnly = value

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

    <Category("Administración Formularios"), Description("Indica la cantidad de máxima de carácteres")> _
    Public Property MaxLength() As Integer
        Get
            Return Me.txtControl.Properties.MaxLength
        End Get
        Set(ByVal value As Integer)
            Me.txtControl.Properties.MaxLength = value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return Me.txtControl.Text
        End Get
        Set(ByVal value As String)
            Try
                Me.Valor = value
            Catch ex As Exception

            End Try
        End Set
    End Property

    <Category("Administración Formularios"), Description("Indica si el contenido se muestra en mayuscula o minuscula")> _
    Public Property CharacterCasing() As System.Windows.Forms.CharacterCasing
        Get
            Return Me.txtControl.Properties.CharacterCasing
        End Get
        Set(ByVal Value As System.Windows.Forms.CharacterCasing)
            Me.txtControl.Properties.CharacterCasing = Value
        End Set
    End Property

    <Category("Administración Formularios"), Description("Indica el caracter utilizado para cajas de texto para claves")> _
    Public Property PassWordChar() As Char
        Get
            Return Me.txtControl.Properties.PasswordChar
        End Get
        Set(ByVal value As Char)
            Me.txtControl.Properties.PasswordChar = value
        End Set
    End Property



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
                        Me.Height = Me.txtControl.Height
                    Else
                        Me.Height = Me.txtControl.Height
                    End If
                    ''Me.SplitControl.Panel1MinSize = Me.LabelWidth

                Case LOrientacion.Superior
                    Me.Height = Me.txtControl.Height + Me.lblControl.Font.SizeInPoints + 8
                    Me.SplitControl.Orientation = Orientation.Horizontal
                    Me.SplitControl.SplitterDistance = Me.lblControl.Font.SizeInPoints + 7

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

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
