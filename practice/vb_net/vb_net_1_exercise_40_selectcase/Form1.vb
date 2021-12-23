Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim message As String
        Select Case Now.DayOfWeek
            Case DayOfWeek.Monday
                message = "Have a nice week"
            Case DayOfWeek.Friday
                message = "Have a nice weekend"
            Case Else
                message = "Weclome back!"
        End Select
        MsgBox(message)
    End Sub
End Class
