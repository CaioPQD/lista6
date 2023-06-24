using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de letras a serem inseridas: ");
        int quantidadeLetras = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite as letras:");

        // Inserir as letras no arquivo
        using (StreamWriter arquivo = new StreamWriter("letras.txt"))
        {
            for (int i = 0; i < quantidadeLetras; i++)
            {
                char letra = Console.ReadKey().KeyChar;
                arquivo.Write(letra);
            }
        }

        Console.WriteLine();
        Console.WriteLine("As letras foram salvas no arquivo 'letras.txt'.");

        // Ler as letras do arquivo e contar as vogais
        int quantidadeVogais = 0;
        using (StreamReader arquivo = new StreamReader("letras.txt"))
        {
            string letras = arquivo.ReadToEnd();

            foreach (char letra in letras)
            {
                if (IsVogal(letra))
                {
                    quantidadeVogais++;
                }
            }
        }

        Console.WriteLine("A quantidade de vogais é: " + quantidadeVogais);
    }

    static bool IsVogal(char letra)
    {
        char letraMinuscula = char.ToLower(letra);

        return letraMinuscula == 'a' || letraMinuscula == 'e' || letraMinuscula == 'i' || letraMinuscula == 'o' || letraMinuscula == 'u';
    }
}