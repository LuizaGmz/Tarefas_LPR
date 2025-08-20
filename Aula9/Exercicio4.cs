
using System;
using System.Collections.Generic; // Necessário para usar Dictionary e List

class Program
{
    static void Main()
    {
        // Solicita ao usuário o número de pessoas que deseja cadastrar
        Console.Write("Quantas pessoas deseja inserir? ");
        int X = int.Parse(Console.ReadLine());

        // Cria um dicionário para armazenar nome (chave) e idade (valor)
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        // Entrada de dados: lê nome e idade de cada pessoa
        for (int i = 0; i < X; i++)
        {
            Console.Write("Nome da pessoa " + (i + 1) + ": ");
            string nome = Console.ReadLine();

            Console.Write("Idade de " + nome + ": ");
            int idade = int.Parse(Console.ReadLine());

            pessoas.Add(nome, idade); // Adiciona ao dicionário
        }

        // Exibe todas as pessoas cadastradas
        Console.WriteLine("\n--- Pessoas cadastradas ---");
        foreach (var p in pessoas)
        {
            Console.WriteLine(p.Key + " -> " + p.Value);
        }

        // 1) Calcular a média das idades
        int soma = 0;
        foreach (var idade in pessoas.Values)
        {
            soma += idade; // Soma todas as idades
        }
        double media = (double)soma / pessoas.Count; // Calcula a média

        Console.WriteLine("\nIdade média: " + media);

        // Exibe pessoas com idade acima da média
        Console.WriteLine("Pessoas com idade acima da média:");
        foreach (var p in pessoas)
        {
            if (p.Value > media)
            {
                Console.WriteLine(p.Key + " (" + p.Value + ")");
            }
        }

        // 2) Encontrar a pessoa mais velha e a mais nova
        string maisVelho = null, maisNovo = null;
        int idadeMax = int.MinValue, idadeMin = int.MaxValue;

        foreach (var p in pessoas)
        {
            if (p.Value > idadeMax) // Atualiza a pessoa mais velha
            {
                idadeMax = p.Value;
                maisVelho = p.Key;
            }
            if (p.Value < idadeMin) // Atualiza a pessoa mais nova
            {
                idadeMin = p.Value;
                maisNovo = p.Key;
            }
        }

        Console.WriteLine("\nPessoa mais velha: " + maisVelho + " (" + idadeMax + ")");
        Console.WriteLine("Pessoa mais nova: " + maisNovo + " (" + idadeMin + ")");

        // 3) Remover pessoas com idade igual a Y
        Console.Write("\nDigite um valor Y de idade para remover: ");
        int Y = int.Parse(Console.ReadLine());

        // Criamos uma lista auxiliar porque não podemos remover itens de um dicionário enquanto iteramos sobre ele
        List<string> remover = new List<string>();

        foreach (var p in pessoas)
        {
            if (p.Value == Y)
            {
                remover.Add(p.Key); // Adiciona à lista de remoção
            }
        }

        // Remove as pessoas listadas da lista auxiliar
        foreach (var nome in remover)
        {
            pessoas.Remove(nome);
        }

        // Exibe o dicionário atualizado
        Console.WriteLine("\n--- Dicionário atualizado ---");
        foreach (var p in pessoas)
        {
            Console.WriteLine(p.Key + " -> " + p.Value);
        }
    }
}
//saudades dos comentarios que tinhas nas aulas 4 e 5.