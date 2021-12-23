Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim number, total As Double
        number = 0
        While number >= 0
            total = total + number
            MsgBox("Current total value is " & total)
            number = InputBox("Please enter another value")
        End While
    End Sub
End Class
