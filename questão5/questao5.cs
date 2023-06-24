using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o caminho completo do arquivo de texto: ");
        string caminhoArquivo = Console.ReadLine();

        try
        {
            // Verifica se o arquivo existe
            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("O arquivo não foi encontrado.");
                return;
            }

            // Lê todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            // Imprime o conteúdo linha a linha
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }

            // Exibe a quantidade de linhas
            int quantidadeLinhas = linhas.Length;
            Console.WriteLine($"O arquivo possui {quantidadeLinhas} linha(s).");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + ex.Message);
        }
    }
}