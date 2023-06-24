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
            // Lê todo o conteúdo do arquivo
            string conteudo = File.ReadAllText(caminhoArquivo);

            // Conta a quantidade de caracteres 'a' no conteúdo
            int quantidadeA = 0;
            foreach (char c in conteudo)
            {
                if (c == 'a' || c == 'A')
                {
                    quantidadeA++;
                }
            }

            // Exibe a quantidade de caracteres 'a'
            Console.WriteLine("A quantidade de caracteres 'a' no arquivo é: " + quantidadeA);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("O arquivo não foi encontrado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + ex.Message);
        }
    }
}