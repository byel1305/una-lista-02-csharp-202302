using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o valor do produto: ");
        double valorOriginal = Convert.ToDouble(Console.ReadLine());


        double novoValor = valorOriginal + (valorOriginal * 0.10);

        Console.WriteLine("Novo valor do produto: " + novoValor.ToString("F2")); 


        Console.ReadLine();
    }
}
