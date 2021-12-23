Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 12 - Show infinite result
        'Dim dblVar As Double = 999
        'Dim infVar As Double
        'infVar = dblVar / 0
        'MsgBox(infVar)

        ' 13 - Show infinite result
        'Dim largeVar As Double = 1.0E+299
        'Dim smallVar As Double = 1.0E-299
        'Dim result As Double
        'result = largeVar / smallVar
        'MsgBox(result)

        ' 15 - Test for NaN but not for these
        'Dim result As Integer
        'MsgBox(result)
        'MsgBox(IsNothing(result))
        'result = result + result
        'result = 10 / result
        'result = result + 1.0E+299
        'MsgBox(result)

        ' 15 - Show NaN
        'Dim result As Double = Double.NaN
        'result = result + result
        'result = 10 / result
        'result = result + 1.0E+299
        'MsgBox(result)

        ' 17 - Handling NaN and Infinity Values
        'Dim var1, var2 As Double
        'Dim result As Double
        'var1 = 0
        'var2 = 0
        'result = var1 / var2
        'If result.IsInfinity(result) Then
        '    If result.IsPositiveInfinity(result) Then
        '        MsgBox("Encountered a very large number. Can't continue")
        '    Else
        '        MsgBox("Encountered a very small number. Can't continue")
        '    End If
        'Else
        '    If result.IsNaN(result) Then
        '        MsgBox("Unexpected error in calculations")
        '    Else
        '        MsgBox("The result is " & result.ToString)
        '    End If
        'End If

        ' 20 - Brush
        'Dim brush As System.Drawing.Brush
        'brush = New System.Drawing.Brush(bmap)
        'brush = Nothing

        ' 21 - GetType() & GetTypeCode()
        'Dim var1 As Int16
        'MsgBox(TypeName(var1))
        'MsgBox(var1.GetType().ToString())
        'MsgBox(var1.GetTypeCode())

        ' 24 - Constant
        'Dim pi As Double = Math.PI

        ' 32 - Array Limits
        'Dim myArray(4) As Integer
        'MsgBox(myArray.GetUpperBound(0) & vbNewLine &
        '       myArray.GetLowerBound(0) & vbNewLine &
        '       UBound(myArray))

    End Sub

    ' 20 - Brush
    'Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    '    Dim blueBrush As New Drawing.SolidBrush(Color.Blue)

    '    e.Graphics.FillRectangle(blueBrush, 20, 30, 100, 100)

    'End Sub
End Class
