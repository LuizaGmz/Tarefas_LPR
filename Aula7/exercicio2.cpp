#include <iostream>
using namespace std;

int main() {
    // Vetor com os nomes das cidades
    string cidades[4] = {"Vitoria", "Belo Horizonte", "Rio de Janeiro", "Sao Paulo"};

    // Matriz de distâncias entre as cidades (em km)
    // Cada linha representa a cidade de origem e cada coluna a cidade de destino
    int matriz[4][4] = {
        {0, 524, 521, 882},  // Distâncias de Vitória
        {524, 0, 434, 586},  // Distâncias de Belo Horizonte
        {521, 434, 0, 429},  // Distâncias do Rio de Janeiro
        {882, 586, 429, 0}   // Distâncias de São Paulo
    };

    int origem, destino;

    do {
        // Mostra o menu com as cidades
        cout << "Escolha duas cidades:" << endl;
        for (int i = 0; i < 4; i++) {
            cout << i + 1 << " - " << cidades[i] << endl;
        }

        // Entrada do usuário para origem e destino
        cout << "Origem (1 a 4): ";
        cin >> origem;
        cout << "Destino (1 a 4): ";
        cin >> destino;

        // Validação das entradas
        if (origem < 1 || origem > 4 || destino < 1 || destino > 4) {
            cout << "Tente novamente.\n";
            continue; // Volta ao início do loop
        }

        // Ajusta os índices para começar de 0 (vetor)
        origem--;
        destino--;

        // Caso origem e destino sejam iguais
        if (origem == destino) {
            cout << "Origem e destino são a mesma cidade.\n";
        } else {
            // Mostra a distância entre as duas cidades
            cout << "A distancia entre " << cidades[origem] << " e " << cidades[destino]
                 << " e de " << matriz[origem][destino] << " km.\n";
        }

    } while (origem != destino); // Repete até o usuário escolher a mesma cidade para origem e destino

    return 0;
}
