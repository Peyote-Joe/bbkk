// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        Polinomio p1 = new Polinomio("9x7-3x3-7x+5");
        Polinomio p2 = new Polinomio("4x2-1");
        Polinomio suma = Polinomio.Suma(p1, p2);

        Console.WriteLine(suma);  // Debería mostrar: 9x7-3x3+4x2-7x+4
    }
}