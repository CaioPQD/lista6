using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de veículos da locadora: ");
        int quantidadeVeiculos = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor do aluguel por veículo: R$");
        double valorAluguel = double.Parse(Console.ReadLine());

        // Faturamento anual
        double faturamentoAnual = quantidadeVeiculos * valorAluguel * 12 / 3;

        // Valor ganho com multas no mês
        double valorMultas = quantidadeVeiculos * valorAluguel * 0.1 * 0.2;

        // Valor gasto com manutenção anual
        double valorManutencao = quantidadeVeiculos * 0.02 * 600.0;

        Console.WriteLine("Faturamento anual: R$" + faturamentoAnual);
        Console.WriteLine("Valor ganho com multas no mês: R$" + valorMultas);
        Console.WriteLine("Valor gasto com manutenção anual: R$" + valorManutencao);

        // Gravar resultados no arquivo
        using (StreamWriter arquivo = new StreamWriter("resultado.txt"))
        {
            arquivo.WriteLine("Faturamento anual: R$" + faturamentoAnual);
            arquivo.WriteLine("Valor ganho com multas no mês: R$" + valorMultas);
            arquivo.WriteLine("Valor gasto com manutenção anual: R$" + valorManutencao);
        }

        Console.WriteLine("Os resultados foram gravados no arquivo 'resultado.txt'.");
    }
}