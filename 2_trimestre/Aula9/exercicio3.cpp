#include <iostream> // Biblioteca para entrada e saída de dados
#include <list>     // Biblioteca que fornece a estrutura de lista (lista duplamente ligada)
#include <ctime>    // Biblioteca para manipulação de tempo (usada para gerar seed aleatória)

using namespace std;

int main() {
    // Cria duas listas: uma para todos os números, outra para os ímpares
    list<int> numeros;
    list<int> impares;

    // Inicializa a semente do gerador de números aleatórios com o tempo atual
    srand(time(NULL));

    // Gerar 100 números aleatórios entre 0 e 99
    for (int i = 0; i < 100; i++) {
        int numero = rand() % 100; // Gera um número aleatório
        numeros.push_back(numero);  // Adiciona à lista "numeros"
    }

    // Ordena a lista "numeros" em ordem crescente
    numeros.sort();

    // Separar apenas os números ímpares
    for (int numero : numeros) {  // Loop baseado em intervalo (range-based for)
        if (numero % 2 != 0) {    // Se o número for ímpar
            impares.push_back(numero); // Adiciona à lista "impares"
            cout << numero << " ";     // Imprime o número ímpar
        }
    }

    cout << endl << endl; // Quebra de linha dupla para separar seções de saída

    // Verificar números repetidos na lista de ímpares
    bool Repeat = false;   // Flag para marcar se houve repetição
    int anterior = -1;     // Armazena o número anterior durante a iteração

    cout << "Numeros repetidos:" << endl;
    for (int numero : impares) { // Percorre a lista de números ímpares
        if (numero == anterior) { // Se o número atual é igual ao anterior
            cout << numero << " "; // Imprime o número repetido
            Repeat = true;          // Marca que houve repetição
        }
        anterior = numero; // Atualiza o número anterior
    }

    // Se não houver números repetidos, exibe mensagem
    if (!Repeat) {
        cout << "Nenhum numero se repete.";
    }

    cout << endl; // Quebra de linha final
    return 0;     // Encerra o programa
}
