using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de segundos: ");
        int segundos = Convert.ToInt32(Console.ReadLine());


        int horas = segundos / 3600; // 3600 segundos em uma hora
        segundos %= 3600;
        int minutos = segundos / 60; // 60 segundos em um minuto
        segundos %= 60;

        Console.WriteLine($"Tempo correspondente: {horas} horas, {minutos} minutos, {segundos} segundos.");


        Console.ReadLine();
    }
}