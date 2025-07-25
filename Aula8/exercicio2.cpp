#include <iostream>

using namespace std;

struct Livro
{
    string Nome;
    string Autor;
    int Ano;
    int numPag;
    double preco;

};


int main(){

double total = 0;
double mediaPag = 0;

    Livro livros[3];

    for(int i= 0; i < 3 ;i++){

        cout << "Entre com o nome do " << i+1 << " livro:";
        cin >> livros[i].Nome;

        cout << "Entre com o nome do " << i+1 << "autor do livro";
        cin >> livros[i].Autor;

        cout << "Entre com o numero de paginas do " << i+1 << "livro";
        cin >> livros[i].numPag;

        cout << "Entre com o preco do " << i+1 << "livro";
        cin >> livros[i].preco;

        total += livros[i].preco;
        mediaPag += livros[i].numPag/3;



    }
    cout << "O preço total dos livros e de " << total;
    cout << "A media de paginas equivale a " << mediaPag;

    return 0;

}