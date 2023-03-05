using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double temperatura = 0.0;

        Console.WriteLine("Digite a temperatura em graus CELSIUS");
        temperatura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        temperatura = 1.8 * temperatura + 32;
        Console.WriteLine("A temperatura em graus fahrenheit é " + temperatura.ToString("F2", CultureInfo.InvariantCulture));
    }
}