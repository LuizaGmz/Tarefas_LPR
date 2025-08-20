using System;

class Program
{
    static void Main()
    {
        //Matrizes
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        int[,] C = new int[3, 3];

        Console.WriteLine("Digite os elementos da primeira matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"A[{i}][{j}]: ");
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Digite os elementos da segunda matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"B[{i}][{j}]: ");
                B[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Matriz A X B X C
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("Matriz C (A * B):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(C[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
