#include <iostream>

using namespace std;

int main(){
    // Vetor para armazenar os 10 números digitados pelo usuário
    int num[10];

    // Vetores para armazenar números pares e ímpares separadamente
    int vetpar[10];
    int vetimpar[10];

    // Contadores para os vetores de pares e ímpares
    int par = 0;
    int impar = 0;
    
    // Entrada de dados
    cout << "Insira 10 numeros inteiros" << endl;
    for (int i = 0; i < 10; i++){
        cout << "Digite o elemento " << i + 1 << ": ";
        cin >> num[i]; // Lê cada número do usuário
    }

    // Separando os números em pares e ímpares
    for(int i = 0; i < 10; i++){
        if(num[i] % 2 == 0){
            // Número par: adiciona ao vetor de pares e incrementa o contador
            vetpar[par] = num[i];
            par++;
        }
        else{
            // Número ímpar: adiciona ao vetor de ímpares e incrementa o contador
            vetimpar[impar] = num[i];
            impar++;
        }
    }

    // Exibindo os números pares
    cout << "Numeros pares: ";
    for(int j = 0; j < par; j++){
        cout << vetpar[j] << " ";
    }
    cout << endl;

    // Exibindo os números ímpares
    cout << "Numeros impares: ";
    for(int j = 0; j < impar; j++){
        cout << vetimpar[j] << " ";
    }
    cout << endl;

    return 0;
}
