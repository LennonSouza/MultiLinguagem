Module Program
    Sub Main(args As String())
        Dim minimo, maximo As Integer

        Console.Write("Digite o valor minimo: ")
        If Not Integer.TryParse(Console.ReadLine(), minimo) Then
            Console.WriteLine("Valor mínimo inválido.")
            Return
        End If

        Console.Write("Digite o valor maximo: ")
        If Not Integer.TryParse(Console.ReadLine(), maximo) Then
            Console.WriteLine("Valor máximo inválido.")
            Return
        End If

        PrintFibonacciSequence(minimo, maximo)
    End Sub

    Sub PrintFibonacciSequence(minimum As Integer, maximum As Integer)
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
End Module
