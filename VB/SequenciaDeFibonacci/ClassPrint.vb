Public Class ClassPrint
    Public Shared Sub PrintFibonacciSequence(minimum As Integer, maximum As Integer)
        Dim param1 = 1, param2 = 1, resultado = 1

        For i = 1 To maximum Step 1
            param1 = param2
            param2 = resultado
            resultado = param1 + param2

            If minimum <= i AndAlso i <= maximum Then
                Console.WriteLine($"{param1} + {param2} = {resultado}")
            End If
        Next
    End Sub
End Class
