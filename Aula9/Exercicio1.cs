using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Quantos nomes deseja inserir? ");
        int X = Convert.ToInt32(Console.ReadLine());

        List<string> nomes = new List<string>();

        // Entrada dos nomes
        Console.WriteLine("Digite os nomes:");
        for (int i = 0; i < X; i++)
        {
            string nome = Convert.ToString(Console.ReadLine());
            nomes.Add(nome);
        }

        // Ordena por tamanho (usando Comparison simples)
        nomes.Sort((a, b) => a.Length.CompareTo(b.Length));

        // Lista auxiliar para marcar quem já foi usado
        bool[] usados = new bool[nomes.Count];
        bool terminou = false;

        // Enquanto ainda houver nomes não usados
        while (!terminou)
        {
            int ultimoTamanho = -1;
            terminou = true;

            for (int i = 0; i < nomes.Count; i++)
            {
                if (!usados[i] && nomes[i].Length != ultimoTamanho)
                {
                    Console.Write(nomes[i] + " ");
                    usados[i] = true;
                    ultimoTamanho = nomes[i].Length;
                }
            }

            Console.WriteLine();

            // Verifica se ainda sobrou algum nome não usado
            for (int i = 0; i < usados.Length; i++)
            {
                if (!usados[i])
                {
                    terminou = false;
                    break;
                }
            }
        }
    }
}
