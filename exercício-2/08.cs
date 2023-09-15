using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o total de veículos no estacionamento: ");
        int totalVeiculos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o total de rodas no estacionamento: ");
        int totalRodas = Convert.ToInt32(Console.ReadLine());


        int carros = totalRodas / 4;
        int motos = (totalRodas - (carros * 4)) / 2;

        Console.WriteLine($"Há {carros} carros e {motos} motos no estacionamento.");


        Console.ReadLine();
    }
}