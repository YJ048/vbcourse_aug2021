Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dblVar As Double = 999
        'Dim infVar As Double
        'infVar = dblVar / 0
        'MsgBox(infVar)

        'Dim largeVar As Double = 1.0E+299
        'Dim smallVar As Double = 1.0E-299
        'Dim result As Double

        'result = largeVar / smallVar
        'MsgBox(result)

        Dim result As Double = Double.NaN

        result = result + result
        result = 10 / result
        result = result + 1.0E+299
        MsgBox(result)


    End Sub
End Class
