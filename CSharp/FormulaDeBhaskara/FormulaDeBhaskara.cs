namespace FormulaDeBhaskara;

public class FormulaDeBhaskara
{
    public static void Main(string[] args)
    {
        Console.Title = "Formula De Bhaskara";

        int a, b, c;

        if (!Entrada.ObterCoeficiente("A", out a) || !Entrada.ObterCoeficiente("B", out b) || !Entrada.ObterCoeficiente("C", out c)) return;

        Console.WriteLine($"Resultado 1: {BhaskaraCalculadora.Resultado1(a, b, c)}");
        Console.WriteLine($"Resultado 2: {BhaskaraCalculadora.Resultado2(a, b, c)}");
    }
}