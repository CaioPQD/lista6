using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "caminho_do_arquivo.txt"; // Especifique o caminho do arquivo de texto aqui

        if (File.Exists(filePath))
        {
            try
            {
                double maxValue = double.MinValue;
                double minValue = double.MaxValue;
                double sum = 0;
                int count = 0;

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (double.TryParse(line, out double number))
                    {
                        // Atualiza o valor máximo
                        if (number > maxValue)
                            maxValue = number;

                        // Atualiza o valor mínimo
                        if (number < minValue)
                            minValue = number;

                        // Soma os valores
                        sum += number;

                        // Incrementa o contador
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"A linha '{line}' não contém um número válido.");
                    }
                }

                if (count > 0)
                {
                    double average = sum / count;

                    Console.WriteLine($"Valor Máximo: {maxValue}");
                    Console.WriteLine($"Valor Mínimo: {minValue}");
                    Console.WriteLine($"Média: {average}");
                }
                else
                {
                    Console.WriteLine("O arquivo está vazio ou não contém números válidos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("O arquivo não existe.");
        }

        Console.ReadLine();
    }
}