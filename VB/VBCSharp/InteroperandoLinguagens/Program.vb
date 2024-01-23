Imports InteroperarComVB

Module Program
    Sub Main(args As String())

        Dim nome As String = "Lennon"
        Dim valor As Integer = 2

        Dim minhaInstancia As New MinhaClass()
        minhaInstancia.Test(nome, valor)
    End Sub
End Module
