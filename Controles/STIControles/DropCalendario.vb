Public Class DropCalendario
    Dim FechaOK As Boolean = False
    Public parentRectangle As Rectangle

    Private Sub DropCalendario_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Call SalirSinCambios()
    End Sub

    Private Sub DropCalendario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call SalirSinCambios()
        End If
    End Sub

    Private Sub MonthCalendar1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MonthCalendar1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call SalirSinCambios()
        End If
    End Sub

    Private Sub SalirSinCambios()
        If FechaOK = False Then
            Me.Tag = ""
            MostrandoCalendario = False
            Me.Close()
        End If
    End Sub

    Private Sub DropCalendario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Me.Tag <> "" Then
                MonthCalendar1.SetDate(CDate(Me.Tag))
            End If
            Call UbicarFormulario()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Try
            Me.Tag = MonthCalendar1.SelectionStart
            Me.FechaOK = True
            MostrandoCalendario = False
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UbicarFormulario()
        Dim StartLocation As Point = New Point(0, 0)
        Dim DisplayedOnScreen As Screen = Screen.FromPoint(New Point(parentRectangle.X, parentRectangle.Bottom))
        Dim MinScreenXPos As Integer = DisplayedOnScreen.Bounds.X
        Dim MinScreenYPos As Integer = DisplayedOnScreen.Bounds.Y
        Dim MaxScreenXPos As Integer = DisplayedOnScreen.Bounds.X + DisplayedOnScreen.Bounds.Width
        Dim MaxScreenYPos As Integer = DisplayedOnScreen.Bounds.Y + DisplayedOnScreen.Bounds.Height
        Dim DropdownWidth As Integer = Width
        Dim DropdownHeight As Integer = Height
        If ((parentRectangle.X + DropdownWidth) <= MaxScreenXPos) Then
            If (parentRectangle.X < MinScreenXPos) Then
                StartLocation.X = MinScreenXPos
            Else
                StartLocation.X = parentRectangle.X
            End If
        Else
            If Screen.FromPoint(New Point(parentRectangle.X + parentRectangle.Width, 0)) Is DisplayedOnScreen Then
                StartLocation.X = parentRectangle.Right - DropdownWidth
            Else
                StartLocation.X = MaxScreenXPos - DropdownWidth
            End If
        End If
        If ((parentRectangle.Bottom + DropdownHeight) <= MaxScreenYPos) Then
            StartLocation.Y = parentRectangle.Bottom
        Else
            StartLocation.Y = parentRectangle.Y - DropdownHeight
        End If
        Me.Location = StartLocation
    End Sub

End Class