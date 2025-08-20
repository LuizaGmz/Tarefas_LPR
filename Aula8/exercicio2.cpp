#include <iostream> // Necessário para usar cout e cin
using namespace std;

// Define uma estrutura para representar um livro
struct Livro
{
    string Nome;    // Nome do livro
    string Autor;   // Autor do livro
    int Ano;        // Ano de publicação (não usado no código)
    int numPag;     // Número de páginas
    double preco;   // Preço do livro
};

int main() {

    double total = 0;     // Acumula o preço total dos livros
    double mediaPag = 0;  // Acumula a soma das páginas para calcular a média

    Livro livros[3];      // Cria um array para armazenar 3 livros

    // Loop para ler os dados de cada livro
    for(int i = 0; i < 3; i++) {

        cout << "Entre com o nome do " << i+1 << " livro: ";
        cin >> livros[i].Nome;  // Lê o nome do livro

        cout << "Entre com o nome do " << i+1 << " autor do livro: ";
        cin >> livros[i].Autor; // Lê o autor do livro

        cout << "Entre com o numero de paginas do " << i+1 << " livro: ";
        cin >> livros[i].numPag; // Lê o número de páginas

        cout << "Entre com o preco do " << i+1 << " livro: ";
        cin >> livros[i].preco;  // Lê o preço do livro

        total += livros[i].preco;        // Soma o preço ao total
        mediaPag += livros[i].numPag/3;  // Soma as páginas dividindo por 3 (para média)
    }

    // Exibe o preço total dos livros
    cout << "O preço total dos livros é de " << total << endl;

    // Exibe a média de páginas
    cout << "A media de paginas equivale a " << mediaPag << endl;

    return 0;
}
