namespace SequenciaDeFibonacci;

public class Fibonacci
{
    public static void Main(string[] args)
    {
        int param1 = 1, param2 = 1, resultado = 1;

        Console.Write("Digite o valor minimo: ");
        int minimo = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Digite o valor maximo: ");
        int maximo = int.Parse(Console.ReadLine());

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