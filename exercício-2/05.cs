using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o número de horas trabalhadas no mês: ");
        int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor recebido por hora de trabalho: ");
        double valorPorHora = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor do salário família: ");
        double salarioFamilia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o número de filhos com idade menor que 14 anos: ");
        int numFilhosMenor14 = Convert.ToInt32(Console.ReadLine());


        double salarioBruto = horasTrabalhadas * valorPorHora + (salarioFamilia * numFilhosMenor14);

        Console.WriteLine("O salário bruto a ser recebido é: " + salarioBruto.ToString("C2")); 


        Console.ReadLine();
    }
}
