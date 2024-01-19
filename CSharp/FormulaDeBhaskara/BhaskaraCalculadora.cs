namespace FormulaDeBhaskara;

public class BhaskaraCalculadora
{
    public static double Delta(int a, int b, int c) => Math.Pow(b, 2) - 4 * a * c;

    public static double Resultado1(int a, int b, int c) => (-b + Math.Sqrt(Delta(a, b, c))) / (2 * a);

    public static double Resultado2(int a, int b, int c) => (-b - Math.Sqrt(Delta(a, b, c))) / (2 * a);
}
