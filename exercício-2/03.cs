using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
        double temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());


        double temperaturaCelsius = (temperaturaFahrenheit - 32) / 1.8;

        Console.WriteLine("A temperatura equivalente em graus Celsius é: " + temperaturaCelsius.ToString("F2"));


        Console.ReadLine();
    }
}