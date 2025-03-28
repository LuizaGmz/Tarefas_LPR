#include <iostream>

using namespace std; 

int main()
{

    int i, result, soma = 0;
    cout << "Digite um numero: ";
    cin >> i;

    result = i*i;

    while (result > 0){
        soma += result % 10;
        result /= 10;

    }
    cout << "A soma dos digitos ao quadrado do numero " << i << " é: " << soma << endl;
    return 0;
    
}