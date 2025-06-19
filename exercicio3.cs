using System;
class Program
{

    static void Main()
    {
        // Vetor
        int[] num = new int[10];

        // Variáveis
        int FBI;
        int repet = 0;

        Console.WriteLine("Insira 10 numeros inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1} elemento: ");
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Digite um numero que gostaria de pesquisar: ");
        FBI = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            if (num[i] == FBI)
            {
                Console.WriteLine($"O número {FBI} foi encontrado na posicao {i + 1}");
                repet++;
            }
            Console.WriteLine($"O FBI encontrou {repet} Ocorrencias:");
        else {
            Console.WriteLine("Nenhuma Ocorrencia");
        }
        }

    }

}