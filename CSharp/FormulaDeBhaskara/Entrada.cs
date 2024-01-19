namespace FormulaDeBhaskara;

public class Entrada
{
    public static bool ObterCoeficiente(string Name, out int coeficiente)
    {
        Console.Write($"Digite valor de '{Name}': ");
        if (!int.TryParse(Console.ReadLine(), out coeficiente))
        {
            Console.WriteLine($"Entrada inválida para o valor '{Name}'. Certifique-se de inserir um número inteiro.");
            return false;
        }
        return true;
    }
}