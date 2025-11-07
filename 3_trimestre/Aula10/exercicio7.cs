using System;
using System.Collections.Generic;
using System.Linq;

class Aluno
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public Aluno(string nome)
    {
        Nome = nome;
    }

    public void Matricular(Turma turma)
    {
        // f) verifica se já está matriculado naquela turma
        if (Matriculas.Any(m => m.Turma == turma))
        {
            Console.WriteLine($"Aluno {Nome} já está matriculado na turma {turma.Nome}!");
            return;
        }

        Matricula novaMatricula = new Matricula(this, turma, DateTime.Now);
        Matriculas.Add(novaMatricula);
        turma.Matriculas.Add(novaMatricula);

        Console.WriteLine($"Aluno {Nome} matriculado na turma {turma.Nome}!");
    }
}

class Turma
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public Turma(string nome)
    {
        Nome = nome;
    }

    public List<Aluno> ListarAlunos()
    {
        return Matriculas.Select(m => m.Aluno).ToList();
    }
}

class Matricula
{
    public Aluno Aluno { get; set; }
    public Turma Turma { get; set; }
    public DateTime DataMatricula { get; set; } // e

    public Matricula(Aluno aluno, Turma turma, DateTime data)
    {
        Aluno = aluno;
        Turma = turma;
        DataMatricula = data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno a1 = new Aluno("Sparky");
        Aluno a2 = new Aluno("Luiza");
        
        Turma t1 = new Turma("Programação OOP");
        Turma t2 = new Turma("Banco de Dados");

        // matriculando
        a1.Matricular(t1);
        a1.Matricular(t2);
        a1.Matricular(t1); // teste duplicado

        a2.Matricular(t1);

        Console.WriteLine("\nAlunos na Turma Programação OOP:");
        foreach (var aluno in t1.ListarAlunos())
        {
            Console.WriteLine($"- {aluno.Nome}");
        }

        Console.ReadLine();
    }
}
