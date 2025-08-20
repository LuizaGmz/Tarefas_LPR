using System;
class Program
{
    static void Main()
    {
        // Cria um vetor de 10 posições para armazenar números inteiros
        int[] num = new int[10];

        // Variáveis auxiliares
        int FBI;        // Número que o usuário quer pesquisar
        int repet = 0;  // Contador de quantas vezes o número aparece

        // Solicita ao usuário para inserir 10 números
        Console.WriteLine("Insira 10 numeros inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1} elemento: ");
            num[i] = Convert.ToInt32(Console.ReadLine()); // Lê e converte o número para inteiro
        }

        // Solicita o número a ser pesquisado
        Console.Write("Digite um numero que gostaria de pesquisar: ");
        FBI = Convert.ToInt32(Console.ReadLine());

        // Percorre o vetor para procurar o número
        for (int i = 0; i < 10; i++)
        {
            if (num[i] == FBI)
            {
                // Se o número for encontrado, exibe a posição e incrementa o contador
                Console.WriteLine($"O número {FBI} foi encontrado na posicao {i + 1}");
                repet++;
            }
            
            // Exibe quantas vezes o número foi encontrado até o momento

            Console.WriteLine($"O FBI encontrou {repet} Ocorrencias:");
        }
    }
}
