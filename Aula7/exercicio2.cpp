#include <iostream>
using namespace std;

int main() {
   
    string cidades[4] = {"Vitoria", "Belo Horizonte", "Rio de Janeiro", "Sao Paulo"};

    // Matriz 
    int matriz[4][4] = {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };

    int origem, destino;

    do {
        cout << "Escolha duas cidades:";
        for (int i = 0; i < 4; i++) {
            cout << i + 1 << " - " << cidades[i] << endl;
        }

        cout << "Origem (1 a 4): ";
        cin >> origem;
        cout << "Destino (1 a 4): ";
        cin >> destino;


        if (origem < 1 || origem > 4 || destino < 1 || destino > 4) {
            cout << "Tente novamente.\n";
            continue;
        }

        origem--;
        destino--;

        if (origem == destino) {
            cout << "Origem e destino são a mesma cidade.";
        } else {
            cout << "A distancia entre " << cidades[origem] << " e " << cidades[destino]
                 << " e de " << matriz[origem][destino] << " km.";
        }

    } while (origem != destino);

    return 0;
}
