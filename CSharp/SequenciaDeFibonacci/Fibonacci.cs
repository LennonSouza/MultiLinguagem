namespace SequenciaDeFibonacci;

public class Fibonacci
{
    public static void Main(string[] args)
    {
        Console.Title = "Sequencia de Fibonacci";

        int minimo, maximo;

        Console.Write("Digite o valor minimo: ");
        if (!int.TryParse(Console.ReadLine(), out minimo))
        {
            Console.WriteLine("Entrada inválida para o valor mínimo. Certifique-se de inserir um número inteiro.");
            return;
        }

        Console.Write("Digite o valor maximo: ");
        if (!int.TryParse(Console.ReadLine(), out maximo) || maximo <= minimo)
        {
            Console.WriteLine("Entrada inválida para o valor máximo. Certifique-se de inserir um número inteiro maior que o valor mínimo.");
            return;
        }

        PrintFibonacci(minimo - 1, maximo);
    }

    public static void PrintFibonacci(int minimo, int maximo)
    {
        int param1, param2 = 1, resultado = 1;

        for (int i = 0; i < maximo; i++)
        {
            param1 = param2;
            param2 = resultado;
            resultado = param1 + param2;

            if (i >= minimo && i <= maximo)
            {
                Console.WriteLine($"{param1} + {param2} = {resultado}");
            }
        }
    }
}