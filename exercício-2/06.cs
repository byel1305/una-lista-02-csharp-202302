using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número (base do logaritmo): ");
        double numero2 = Convert.ToDouble(Console.ReadLine());


        double resultado = Math.Log(numero1, numero2);

        Console.WriteLine($"O logaritmo de {numero1} na base {numero2} é: {resultado}");


        Console.ReadLine();
    }
}
