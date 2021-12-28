Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 6 - Subroutine Example
        'ShowDate()

        ' 7 - Subroutine Example 2
        'ShowDate(#04/08/2000#)

        ' 10 - Function Example
        'MsgBox(NextDay())

        ' 11 - Build-In Function Abs
        'MsgBox(Math.Abs(23.3) & vbNewLine & Math.Abs(-23.3))

        ' 12 - Custom Function - ISBNCheckDigit()
        'MsgBox(ISBNCheckDigit("0812962656")) ' 10 Digit ISBN

        ' 13 - Calling a Function Example
        'MsgBox(ISBNCheckDigit("078212283"))

        ' 24 - Call Stats() function
        'Dim Values(100) As Double
        '' Statement to populate the data set
        'Dim average, deviation As Double
        'Dim points As Integer
        'points = (Stats(Values, average, deviation))
        'Console.WriteLine(points & " value processed.")
        'Console.WriteLine("The average is " & average & " and")
        'Console.WriteLine("the standard deviation is " & deviation)

    End Sub

    ' 25 - Passing Objects as Arguments
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim aList As New ArrayList()
    '    PopulateList(aList)
    '    Console.WriteLine(aList(0).ToString)
    '    Console.WriteLine(aList(1).ToString)
    '    Console.WriteLine(aList(2).ToString)
    'End Sub

    ' 6 - Subroutine Example
    'Sub ShowDate()
    '    MsgBox(Now())
    'End Sub

    ' 7 - Subroutine Example 2
    'Sub ShowDate(ByVal birthDate As Date)
    '    MsgBox(birthDate)
    'End Sub

    ' 10 - Function Example
    'Function NextDay() As Date
    '    Dim theNextDay As Date
    '    theNextDay = DateAdd(DateInterval.Day, 1, Now())
    '    Return (theNextDay)
    'End Function

    ' 12 - Custom Function - ISBNCheckDigit() function
    'Function ISBNCheckDigit(ByVal ISBN As String) As String
    '    Dim i As Integer, chkSum, chkDigit As Integer
    '    For i = 0 To 8
    '        chkSum = chkSum + (10 - i) * ISBN.Substring(i, 1)
    '    Next
    '    chkDigit = 11 - (chkSum Mod 11)
    '    If chkDigit = 10 Then
    '        Return ("X")
    '    Else
    '        Return (chkDigit.ToString)
    '    End If
    'End Function

    ' 23 - Stats Function
    'Function Stats(ByRef Data() As Double, ByRef Avg As Double,
    '                ByRef StDev As Double) As Integer
    '    Dim i As Integer, sum As Double, sumSqr As Double, points As Integer
    '    points = Data.Length
    '    For i = 0 To points - 1
    '        sum = sum + Data(i)
    '        sumSqr = sumSqr + Data(i) ^ 2
    '    Next
    '    Avg = sum / points
    '    StDev = System.Math.Sqrt(sumSqr / points - Avg ^ 2)
    '    Return (points)
    'End Function

    ' 25 - Passing Objects As Arguments
    'Sub PopulateList(ByVal list As ArrayList)
    '    list.Add("1")
    '    list.Add("2")
    '    list.Add("3")
    'End Sub

End Class
