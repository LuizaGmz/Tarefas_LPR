#include <iostream>
using namespace std;

int revert(int num) { //suspeito que não sei contar
    int revert = 0;

    while (num != 0) {
        int digito = num % 10;
        revert = revert * 10 + digito;
        num /= 10;
        // n sei se funciona
    }

    return revert;
}


int main() { //aqui eu tive certeza que eu não sabia contar
    int num;
    cout << "Digite um numero inteiro: ";
    cin >> num;

    int resultado = revert(num);
    cout << "O reverso do numero é: " << resultado << endl;

    return 0;
}

