using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseSemVogais = RemoverVogais(frase);

        Console.WriteLine("Frase sem vogais: " + fraseSemVogais);
    }

    static string RemoverVogais(string texto)
    {
        string vogais = "aeiouAEIOU";
        string resultado = "";

        foreach (char c in texto)
        {
            if (!vogais.Contains(c))
            {
                resultado += c;
            }
        }

        return resultado;
    }
}