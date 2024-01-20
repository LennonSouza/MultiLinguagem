namespace SequenciaDeFibonacci
{
    public class ClassPrint
    {
        public static void Print(int minimo, int maximo)
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
}
