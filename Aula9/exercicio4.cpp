#include <iostream> // Biblioteca para entrada e saída de dados
#include <list>     // Biblioteca para listas duplamente ligadas
#include <string>   // Biblioteca para manipulação de strings
using namespace std;

int main() {
    int X;
    cout << "Insira o numero de cidades ";
    cin >> X; // Lê a quantidade de cidades que o usuário vai informar

    // Cria listas para armazenar nomes de cidades e suas populações
    list<string> nomes;
    list<int> habitantes;

    // Entrada de dados: para cada cidade, lê nome e população
    for (int i = 0; i < X; i++) {
        string nome;
        int hab;
        cout << "Nome da cidade " << i+1 << ": ";
        cin >> nome;
        cout << "Quantidade de habitantes: ";
        cin >> hab;
        nomes.push_back(nome);       // Adiciona o nome à lista de nomes
        habitantes.push_back(hab);   // Adiciona a população à lista de habitantes
    }

    // Calcular a população média
    double soma = 0;
    for (int h : habitantes) {  // Percorre todos os habitantes
        soma += h;               // Soma os valores
    }
    double media = soma / X;     // Calcula a média
    cout << "Populacao media: " << media << endl;

    // Listar cidades com população acima da média
    cout << "Cidades acima da media: ";
    list<string>::iterator itNome = nomes.begin();      // Iterador para nomes
    list<int>::iterator ithab = habitantes.begin();    // Iterador para habitantes
    while (itNome != nomes.end() && ithab != habitantes.end()) {
        if (*ithab > media) { // Se a população for maior que a média
            cout << *itNome << " (" << *ithab << " habitantes) ";
        }
        ++itNome;  // Avança o iterador de nomes
        ++ithab;   // Avança o iterador de habitantes
    }

    // Encontrar cidade mais e menos populosa
    itNome = nomes.begin();
    ithab = habitantes.begin();
    string cidadeMais = *itNome;  // Inicializa com a primeira cidade
    string cidadeMenos = *itNome;
    int habMais = *ithab;
    int habMenos = *ithab;

    ++itNome;   // Avança para a próxima cidade
    ++ithab;

    while (itNome != nomes.end() && ithab != habitantes.end()) {
        if (*ithab > habMais) { // Atualiza a cidade mais populosa
            habMais = *ithab;
            cidadeMais = *itNome;
        }
        if (*ithab < habMenos) { // Atualiza a cidade menos populosa
            habMenos = *ithab;
            cidadeMenos = *itNome;
        }
        ++itNome;
        ++ithab;
    }

    cout << "Cidade mais populosa: " << cidadeMais << " (" << habMais << " habitantes)";
    cout << "Cidade menos populosa: " << cidadeMenos << " (" << habMenos << " habitantes)";

    // Remover cidades com população igual a Y
    int Y;
    cout << "Informe uma quantidade de habitantes que deseja remover : ";
    cin >> Y;

    itNome = nomes.begin();
    ithab = habitantes.begin();
    while (itNome != nomes.end() && ithab != habitantes.end()) {
        if (*ithab == Y) { // Se a população for igual a Y
            itNome = nomes.erase(itNome);       // Remove a cidade
            ithab = habitantes.erase(ithab);    // Remove a população correspondente
        } else {
            ++itNome;
            ++ithab;
        }
    }

    // Imprimir lista atualizada de cidades e suas populações
    cout << "\nDicionário atualizado:\n";
    itNome = nomes.begin();
    ithab = habitantes.begin();
    while (itNome != nomes.end() && ithab != habitantes.end()) {
        cout << *itNome << " : " << *ithab << endl;
        ++itNome;
        ++ithab;
    }

    return 0; // Encerra o programa
}
