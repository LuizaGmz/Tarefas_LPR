using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    // Estrutura que define um herói com nome, poder e pontuação
    public struct Heroi
    {
        public int pont;      // Pontuação do herói
        public string nome;   // Nome do herói
        public string poder;  // Poder do herói
    };

    // Array que armazena até 5 heróis
    static Heroi[] herois = new Heroi[5];
    static int totalHerois = 0;       // Contador de heróis cadastrados
    static int[] equipe = new int[3]; // Índices dos heróis selecionados para a equipe
    static bool finalEquip = false;   // Indica se a equipe foi selecionada

    static void Main()
    {
        menuPrincipal(); // Inicia o menu principal
    }

    // Menu principal com opções para o usuário
    static void menuPrincipal()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1 - Cadastrar Herois");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarHerois(); // Chama função para cadastrar heróis
                    break;
                case "2":
                    SelecionarEquipe(); // Chama função para selecionar equipe
                    break;
                case "3":
                    exibirEquipe(); // Chama função para exibir equipe
                    break;
                case "4":
                    exit = true; // Sai do programa
                    break;
            }
        }
    }

    // Função para cadastrar heróis
    static void CadastrarHerois()
    {
        if (totalHerois >= 5)
        {
            Console.WriteLine("Limite excedido");
            return;
        }

        // Cadastro de heróis restantes
        for (int i = totalHerois; i < 5; i++)
        {
            Console.WriteLine($"Digite o nome do {i + 1} heroi:");
            herois[i].nome = Console.ReadLine();

            Console.Write("Poder: ");
            herois[i].poder = Console.ReadLine();

            Console.Write("Pontuaçao: ");
            herois[i].pont = int.Parse(Console.ReadLine());

            totalHerois++; // Atualiza contador
        }
    }

    // Função para selecionar a equipe de 3 heróis
    static void SelecionarEquipe()
    {
        if (totalHerois < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 herois antes de montar a equipe.");
            return;
        }

        // Mostra todos os heróis cadastrados
        Console.WriteLine("--- Lista de Heróis ---");
        for (int i = 0; i < totalHerois; i++)
        {
            Console.WriteLine($"{i + 1} - {herois[i].nome} | Poder: {herois[i].poder} | Pontuação: {herois[i].pont}");
        }

        // Seleção dos 3 heróis para a equipe
        for (int i = 0; i < 3; i++)
        {
            int escolha;
            do
            {
                Console.Write($"\nEscolha o {i + 1}º herói para a equipe (1 a {totalHerois}): ");
                escolha = int.Parse(Console.ReadLine());
            } while (escolha == -1); // Condição básica de validação (poderia ser melhorada)

            equipe[i] = escolha - 1; // Armazena o índice do herói na equipe
        }

        finalEquip = true; // Marca que a equipe foi montada
        Console.WriteLine("\nEquipe selecionada com sucesso!");
    }

    // Calcula a pontuação total da equipe
    static int Calculejadora()
    {
        int total = 0;
        for (int i = 0; i < 3; i++)
        {
            total += herois[equipe[i]].pont;
        }
        return total;
    }

    // Exibe os heróis selecionados na equipe e a pontuação total
    static void exibirEquipe()
    {
        if (!finalEquip)
        {
            Console.WriteLine("Equipe ainda não foi montada.");
            return;
        }

        Console.WriteLine("--- Equipe Selecionada ---");
        for (int i = 0; i < 3; i++)
        {
            Heroi h = herois[equipe[i]];
            Console.WriteLine($"{i + 1} - {h.nome} | Poder: {h.poder} | Pontuação: {h.pont}");
        }

        int pontuacaoTotal = Calculejadora();
        Console.WriteLine($"Pontuacao total: {pontuacaoTotal}");
    }
}
//