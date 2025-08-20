#include <iostream>
#include <list>
#include <ctime>

using namespace std;

int main() {
    list<int> numeros;
    list<int> impares;

    srand(time(NULL));

    // gerar 100 números aleatórios
    for (int i = 0; i < 100; i++) {
        int numero = rand() % 100;
        numeros.push_back(numero);
    }

    // ordenar
    numeros.sort();


    // separar ímpares

    for (int numero : numeros) {
        if (numero % 2 != 0) {
            impares.push_back(numero);
            cout << numero << " ";
        }
    }
    cout << endl << endl;

    // verificar repetidos
    bool Repeat = false;
    int anterior = -1;

    cout << "Numeros repetidos:" << endl;
    for (int numero : impares) {
        if (numero == anterior) {
            cout << numero << " ";
            Repeat = true;
        }
        anterior = numero;
    }

    if (!Repeat) {
        cout << "Nenhum numero se repete.";
    }

    cout << endl;
    return 0;
}
