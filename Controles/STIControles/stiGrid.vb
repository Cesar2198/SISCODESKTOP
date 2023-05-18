Imports System.ComponentModel

Public Class stiGrid

    Private NombreTablaL As String = ""
    Private ColumnasAdicionalesL As String = ""
    Private WithEvents stiVistaDefaul As DevExpress.XtraGrid.Views.Grid.GridView

    <Category("Administración Formularios"), Description("Indica nombre de la tabla hija que se administra en el formulario")> _
    Public Property NombreTabla() As String
        Get
            Return NombreTablaL
        End Get
        Set(ByVal value As String)
            NombreTablaL = value
        End Set
    End Property

    <Category("Administración Formularios"), Description("Indica si hay campos adicionales que obtener automáticamente, estos campos usualmente no se guardan en la tabla")> _
    Public Property ColumnasAdicionales() As String
        Get
            Return ColumnasAdicionalesL
        End Get
        Set(ByVal value As String)
            ColumnasAdicionalesL = value
        End Set
    End Property

    Public Sub EstablecerTipoFiltro(ByVal TipoFiltro As DevExpress.XtraGrid.Columns.FilterPopupMode)
        Try
            Dim VistaDefault As DevExpress.XtraGrid.Views.Grid.GridView = Me.ViewCollection(0)
            Dim ColF As DevExpress.XtraGrid.Columns.GridColumn
            For Each ColF In VistaDefault.Columns
                If ColF.DisplayFormat.FormatType <> DevExpress.Utils.FormatType.DateTime Then
                    ColF.OptionsFilter.FilterPopupMode = TipoFiltro
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles stiVistaDefaul.CellValueChanged
        Try
            'intentamos indicarle al formulario que se modifico un dato.
            If CType(Me.FindForm, Object).blnCargandoRegistro = False Then
                CType(Me.FindForm, Object).blnRegistroModificado = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub stiGrid_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        Try
            stiVistaDefaul = Me.MainView
        Catch ex As Exception

        End Try
    End Sub

End Class
