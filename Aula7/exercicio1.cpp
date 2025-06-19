#include <iostream>

using namespace std;

int main(){
    //Vetores
    int num[10];

    int vetpar[10];
    int vetimpar[10];

    //numeros
    int i;
    int par = 0;
    int impar = 0;
    
    //Lendo os numeros
    cout << "insira 10 numeros inteiros" << endl;

    for (int i = 0; i < 10; i++){
        cout << " digite o elemento " << i + 1 << endl;
        cin >> num[i];
    }

     //Separando os numeros pares e impares
    for(int i = 0; i < 10; i++){
        if(num[i]%2 == 0){
            vetpar[par] = num[i];
            par++;
            

        }
        else{
            vetimpar[impar] = num[i];
            impar++;
        }
        
        }

        cout << "Numero pares:";
        for(int j = 0; j<par; j++){
            cout << vetpar[j] << " ";
        }
        cout << "Numero impares:";
        for(int j =0; j < impar; j++){
            cout << vetimpar[j] << " ";
        }
    }

