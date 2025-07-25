using System.Reflection.Metadata;

using System;
using System.Runtime.InteropServices;
class Program
{

    public struct Heroi
    {
        public int pont;
        public string nome;
        public string poder;
    };
    static Heroi[] herois = new Heroi[5];
    static int totalHerois = 0;
    static int[] equipe = new int[3];
    static bool finalEquip = false;

    static void Main()
    {

        menuPrincipal();
    }
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
                    CadastrarHerois();
                    break;
                case "2":
                    SelecionarEquipe();
                    break;
                case "3":
                    exibirEquipe();
                    break;
                case "4":
                    exit = true;
                    break;

            }
        }

    }

    static void CadastrarHerois()
    {
        if (totalHerois >= 5)
        {
            Console.WriteLine("Limite excedido");

        }
        for (int i = totalHerois; i < 5; i++)
        {
            Console.WriteLine($"Digite o nome do {i + 1} heroi:");
            herois[i].nome =Console.ReadLine();

            Console.Write("Poder: ");
            herois[i].poder = Console.ReadLine();

            Console.Write("Pontuaçao: ");
            herois[i].pont = int.Parse(Console.ReadLine());

            totalHerois++;



        }
    }
    
  static void SelecionarEquipe()
    {
        if (totalHerois < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 herois antes de montar a equipe.");
            return;
        }

        Console.WriteLine("--- Lista de Heróis ---");
        for (int i = 0; i < totalHerois; i++)
        {
            Console.WriteLine($"{i + 1} - {herois[i].nome} | Poder: {herois[i].poder} | Pontuação: {herois[i].pont}");
        }

        for (int i = 0; i < 3; i++)
        {
            int escolha;

            do
            {
                Console.Write($"\nEscolha o {i + 1}º herói para a equipe (1 a {totalHerois}): ");
                escolha = int.Parse(Console.ReadLine());

          

            } while (escolha == -1);

            equipe[i] = escolha - 1;
        }

        finalEquip = true;
        Console.WriteLine("\nEquipe selecionada com sucesso!");
    }

    static int Calculejadora()
    {
        int total = 0;
        for (int i = 0; i < 3; i++)
        {
            total += herois[equipe[i]].pont;
        }
        return total;
    }

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
