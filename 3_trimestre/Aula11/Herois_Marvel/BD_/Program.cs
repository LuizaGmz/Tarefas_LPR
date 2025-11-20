using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;



struct Heroi
{
    public int Id;
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

class Program
{
    static string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Marvel_herois;Integrated Security=True;";
    static List<Heroi> equipe = new List<Heroi>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== SISTEMA MARVEL =====");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Listar Heróis");
            Console.WriteLine("3 - Selecionar Equipe");
            Console.WriteLine("4 - Exibir Equipe");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha: ");
            string opc = Console.ReadLine();

            switch (opc)
            {
                case "1": CadastrarHeroi(); break;
                case "2": ListarHerois(); break;
                case "3": SelecionarEquipe(); break;
                case "4": ExibirEquipe(); break;
                case "5": return;
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // ============================================================
    // CADASTRO
    // ============================================================
    static void CadastrarHeroi()
    {
        Console.Clear();

        Console.Write("Nome do herói: ");
        string nome = Console.ReadLine();

        Console.Write("Poder do herói: ");
        string poder = Console.ReadLine();

        Console.Write("Pontuação do herói: ");
        int pontuacao = int.Parse(Console.ReadLine());

        using (SqlConnection con = new SqlConnection(conexao))

           
        {
            string sql = "INSERT INTO Heroi (Nome, Poder, Pontuacao) VALUES (@n, @p, @pt)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@n", nome);
            cmd.Parameters.AddWithValue("@p", poder);
            cmd.Parameters.AddWithValue("@pt", pontuacao);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        Console.WriteLine("Herói cadastrado com sucesso!");
        Console.ReadKey();
    }

    // ============================================================
    // LISTAR HERÓIS
    // ============================================================
    static List<Heroi> ListarHerois()
    {
        List<Heroi> lista = new List<Heroi>();

        using (SqlConnection con = new SqlConnection(conexao))
        {
            string sql = "SELECT * FROM Heroi";
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Heroi
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Poder = reader.GetString(2),
                    Pontuacao = reader.GetInt32(3)
                });
            }
        }

        Console.WriteLine("\n===== HERÓIS CADASTRADOS =====");
        foreach (var h in lista)
        {
            Console.WriteLine($"{h.Id} - {h.Nome} ({h.Poder}) Pontos: {h.Pontuacao}");
        }
        Console.WriteLine("Pressione uma tecla...");
        Console.ReadKey();

        return lista;
    }

    // ============================================================
    // SELECIONAR EQUIPE
    // ============================================================
    static void SelecionarEquipe()
    {
        equipe.Clear();
        var herois = ListarHerois();

        Console.WriteLine("\nSelecione 3 heróis pelo ID:");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Herói {i + 1}: ");
            int idEscolhido = int.Parse(Console.ReadLine());

            Heroi h = herois.Find(x => x.Id == idEscolhido);
            equipe.Add(h);
        }

        Console.WriteLine("Equipe selecionada com sucesso!");
        Console.ReadKey();
    }

    // ============================================================
    // EXIBIR EQUIPE
    // ============================================================
    static void ExibirEquipe()
    {
        Console.Clear();
        Console.WriteLine("==== EQUIPE MARVEL ====");

        int total = 0;

        foreach (var h in equipe)
        {
            Console.WriteLine($"{h.Nome} - {h.Poder} - Pontos: {h.Pontuacao}");
            total += h.Pontuacao;
        }

        Console.WriteLine($"\nPontuação total da equipe: {total}");
        Console.ReadKey();
    }
}
