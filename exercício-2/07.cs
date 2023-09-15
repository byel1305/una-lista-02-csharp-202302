using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o salário fixo do vendedor: ");
        double salarioFixo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor total das vendas no mês: ");
        double totalVendas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o percentual de comissão (em decimal): ");
        double percentualComissao = Convert.ToDouble(Console.ReadLine());


        double salarioTotal = salarioFixo + (totalVendas * percentualComissao);

        Console.WriteLine("O salário total do vendedor é: " + salarioTotal.ToString("C2")); 


        Console.ReadLine();
    }
}
