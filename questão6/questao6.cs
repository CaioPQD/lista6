using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int somaDivisores = 0;
        Console.Write("Os divisores de " + numero + " são: ");

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.Write(i + " ");
                somaDivisores += i;
            }
        }

        Console.WriteLine();
        Console.WriteLine("A soma dos divisores de " + numero + " é: " + somaDivisores);

        SalvarSomaDivisores(numero, somaDivisores);

        Console.WriteLine("A soma foi salva no arquivo 'soma_divisores.txt'.");
    }

    static void SalvarSomaDivisores(int numero, int somaDivisores)
    {
        using (StreamWriter arquivo = new StreamWriter("soma_divisores.txt"))
        {
            arquivo.WriteLine("A soma dos divisores de " + numero + " é: " + somaDivisores);
        }
    }
}