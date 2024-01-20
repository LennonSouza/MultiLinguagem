namespace SequenciaDeFibonacci;

public class MainFibonacci
{
    public static void Main(string[] args)
    {
        Console.Title = "CSharp Sequencia de Fibonacci";

        int minimo, maximo;
        bool erro;

        while (true)
        {
            erro = false;

            Console.Write("Digite o valor minimo: ");
            if (!int.TryParse(Console.ReadLine(), out minimo))
            {
                Console.WriteLine("Entrada inválida para o valor mínimo. Certifique-se de inserir um número inteiro.");
                erro = true;
            }

            Console.Write("Digite o valor maximo: ");
            if (!int.TryParse(Console.ReadLine(), out maximo) || maximo <= minimo)
            {
                Console.WriteLine("Entrada inválida para o valor máximo. Certifique-se de inserir um número inteiro maior que o valor mínimo.");
                erro = true;
            }

            if(!erro) ClassPrint.Print(minimo - 1, maximo);
        }
    }
}