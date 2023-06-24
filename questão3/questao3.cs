using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseCodificada = CodificarCesar(frase);

        Console.WriteLine("Nova string: " + fraseCodificada);
    }

    static string CodificarCesar(string texto)
    {
        int deslocamento = 3; // número fixo de posições para a troca

        string resultado = "";

        foreach (char c in texto)
        {
            if (char.IsLetter(c)) // verifica se o caractere é uma letra
            {
                char letra = char.ToUpper(c); // converte a letra para maiúscula
                int codigoAscii = ((letra - 'A' + deslocamento) % 26) + 'A'; // aplica o deslocamento no código ASCII da letra

                char letraCodificada = (char)codigoAscii; // converte o código ASCII de volta para caractere

                resultado += letraCodificada;
            }
            else
            {
                resultado += c;
            }
        }

        return resultado;
    }
}