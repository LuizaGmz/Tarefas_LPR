using System;
using System.Collections.Generic;

// Define a classe principal do programa
class Program
{
    // Ponto de entrada do programa
    static void Main()
    {
        // Solicita ao usuário quantos nomes ele quer inserir
        Console.Write("Quantos nomes deseja inserir? ");
        int X = Convert.ToInt32(Console.ReadLine()); // Lê a quantidade e converte para inteiro

        // Cria uma lista para armazenar os nomes digitados
        List<string> nomes = new List<string>();

        // Solicita a entrada dos nomes
        Console.WriteLine("Digite os nomes:");
        for (int i = 0; i < X; i++)
        {
            string nome = Convert.ToString(Console.ReadLine()); // Lê o nome
            nomes.Add(nome); // Adiciona o nome na lista
        }

        // Ordena a lista de nomes pelo tamanho da string, do menor para o maior
        nomes.Sort((a, b) => a.Length.CompareTo(b.Length));

        // Cria um array para marcar quais nomes já foram usados/impressos
        bool[] usados = new bool[nomes.Count];
        bool terminou = false; // Flag para controlar o loop principal

        // Loop principal: continua enquanto houver nomes não usados
        while (!terminou)
        {
            int ultimoTamanho = -1; // Armazena o tamanho do último nome impresso na linha atual
            terminou = true; // Assume que terminou; se algum nome não usado for encontrado, muda para false

            // Percorre todos os nomes
            for (int i = 0; i < nomes.Count; i++)
            {
                // Verifica se o nome não foi usado e se tem tamanho diferente do último impresso
                if (!usados[i] && nomes[i].Length != ultimoTamanho)
                {
                    Console.Write(nomes[i] + " "); // Imprime o nome
                    usados[i] = true; // Marca como usado
                    ultimoTamanho = nomes[i].Length; // Atualiza o último tamanho
                }
            }

            Console.WriteLine(); // Quebra de linha após imprimir os nomes da rodada atual

            // Verifica se ainda existe algum nome não usado
            for (int i = 0; i < usados.Length; i++)
            {
                if (!usados[i])
                {
                    terminou = false; // Se houver, o loop continuará
                    break;
                }
            }
        }
    }
}
