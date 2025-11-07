using System;
using System.Collections.Generic;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }

    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = ano;
    }
}

class Biblioteca
{
    public List<Livro> Livros { get; set; } = new List<Livro>();

    public void AdicionarLivro(Livro l)
    {
        Livros.Add(l);
    }

    public void ListarLivros()
    {
        Console.WriteLine("Livros na Biblioteca:");

        foreach (var livro in Livros)
        {
            Console.WriteLine($"Título: {livro.Titulo} | Autor: {livro.Autor} | Ano: {livro.AnoPublicacao}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblio = new Biblioteca();

        Livro l1 = new Livro("Fate Zero - Light Novel", "Gen Urobuchi", 2006);
        Livro l2 = new Livro("O Hobbit", "J. R. R. Tolkien", 1937);
        Livro l3 = new Livro("O Mito da Beleza", "Naomi Wolf", 1991);

        biblio.AdicionarLivro(l1);
        biblio.AdicionarLivro(l2);
        biblio.AdicionarLivro(l3);

        biblio.ListarLivros();

        Console.ReadLine();
    }
}
