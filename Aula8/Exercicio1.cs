using System; // Necessário para usar Console

// Define uma estrutura para representar um produto
struct Produto
{
    public string Nome;       // Nome do produto
    public int Codigo;        // Código do produto
    public double Preco;      // Preço unitário do produto
    public int Quantidade;    // Quantidade em estoque
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3]; // Cria um array para armazenar 3 produtos
        double totalEstoque = 0;            // Variável para acumular o valor total do estoque

        // Loop para ler os dados dos 3 produtos
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Produto {i + 1}:"); // Exibe o número do produto atual

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine(); // Lê o nome do produto

            Console.Write("Código: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine()); // Lê e converte o código para inteiro

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine()); // Lê e converte o preço para double

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine()); // Lê a quantidade em estoque

            // Atualiza o total do estoque somando o valor do produto atual (preço * quantidade)
            totalEstoque += produtos[i].Preco * produtos[i].Quantidade;

            Console.WriteLine(); // Linha em branco para melhor visualização
        }

        // Exibe o valor total em estoque de todos os produtos
        Console.WriteLine($"Valor total em estoque: R$ {totalEstoque}");
    }
}
