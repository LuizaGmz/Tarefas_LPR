using System;

public class Aluno
{
    public string nome;
    public string matricula;
    public double notaProv1;
    public double notaProv2;
    public double notaTrab;

    public double CalcularMedia()
    {
       return (notaProv1 * 2.5 + notaProv2 * 2.5 + notaTrab * 2) / 7;
    }
    public double verifyFinal()
    {
        double media = CalcularMedia();
        if (media >= 7)
        {
            return 0; // Aprovado
        }
        else
        {
            return 10 - media; // Nota necessária para passar
        }
    }

}


class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.Write("Digite o nome do aluno: ");
        aluno.nome = Console.ReadLine();

        Console.Write("Digite a matrícula do aluno: ");
        aluno.matricula = Console.ReadLine();

        Console.Write("Digite a nota da primeira prova: ");
        aluno.notaProv1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota da segunda prova: ");
        aluno.notaProv2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota do trabalho: ");
        aluno.notaTrab = Convert.ToDouble(Console.ReadLine());

        double media = aluno.CalcularMedia();
        Console.WriteLine($"Média do aluno {aluno.nome}: {media}");

        double notaFinal = aluno.verifyFinal();
        if (notaFinal == 0)
        {
            Console.WriteLine("Aluno aprovado!");
        }
        else
        {
            Console.WriteLine($"Aluno reprovado! Nota necessária para passar: {notaFinal}");
        }
    }
}