Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim testArray(9) As Integer
        MsgBox(testArray.GetUpperBound(0) & vbNewLine & testArray.Length)
    End Sub
End Class
