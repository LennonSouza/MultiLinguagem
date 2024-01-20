Module Main
    Public Sub Main(args As String())
        Console.Title = "VB Sequencia de Fibonacci"

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

        ClassPrint.PrintFibonacciSequence(minimo, maximo)
    End Sub
End Module
