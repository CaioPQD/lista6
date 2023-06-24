using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 - Inserir dados de alunos");
        Console.WriteLine("2 - Ler dados de alunos");
        Console.WriteLine("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            InserirDadosAlunos();
        }
        else if (opcao == 2)
        {
            LerDadosAlunos();
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }

    static void InserirDadosAlunos()
    {
        Console.WriteLine("Digite a matrícula do aluno: ");
        string matricula = Console.ReadLine();

        Console.WriteLine("Digite o telefone do aluno: ");
        string telefone = Console.ReadLine();

        // Criar ou abrir o arquivo para escrita
        using (StreamWriter sw = File.AppendText("alunos.txt"))
        {
            // Escrever os dados no arquivo
            sw.WriteLine("Matrícula: " + matricula);
            sw.WriteLine("Telefone: " + telefone);
            sw.WriteLine();
        }

        Console.WriteLine("Dados do aluno armazenados com sucesso!");
    }

    static void LerDadosAlunos()
    {
        // Verificar se o arquivo existe
        if (File.Exists("alunos.txt"))
        {
            // Ler e exibir os dados do arquivo
            using (StreamReader sr = File.OpenText("alunos.txt"))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        else
        {
            Console.WriteLine("Nenhum dado de aluno encontrado!");
        }
    }
}