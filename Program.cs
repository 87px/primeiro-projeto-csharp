using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira uma string aleatória: ");
        string palavra = Console.ReadLine()!;

        int contador = 0;

        foreach(char str in palavra) {

            if ("aeiouAEIOU".Contains(str)) {
                contador++; // Aumenta o contador;
            }
        }

        Console.WriteLine("Total de vogais encontradas na sua palavra: " + Convert.ToString(contador)); // Exibi o tanto de vogais encontrado.
    }
}

