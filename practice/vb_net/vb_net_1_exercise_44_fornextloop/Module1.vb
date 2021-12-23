Module Module1

    Sub Main()

        'Dim data() As Double = {4, 6, 7, 9, 10}
        Dim data(4) As Double
        data(0) = 4
        data(1) = 6
        data(2) = 7
        data(3) = 9
        data(4) = 10

        Dim i As Integer, total As Double
        For i = 0 To data.GetUpperBound(0)
            total = total + data(i)
        Next i
        Console.WriteLine(total / data.Length)

        Console.ReadLine()

    End Sub

End Module
