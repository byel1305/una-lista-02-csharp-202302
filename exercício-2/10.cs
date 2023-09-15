using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double mediaAritmetica = (a + b + c) / 3;

        double mediaHarmonica = 3 / ((1 / a) + (1 / b) + (1 / c));

        double mediaGeometrica = Math.Pow((a * b * c), 1.0 / 3.0);

        Console.WriteLine($"Média Aritmética: {mediaAritmetica}");
        Console.WriteLine($"Média Harmônica: {mediaHarmonica}");
        Console.WriteLine($"Média Geométrica: {mediaGeometrica}");


        Console.ReadLine();
    }
}