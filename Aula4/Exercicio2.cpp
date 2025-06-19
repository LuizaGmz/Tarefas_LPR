#include <iostream>


using namespace std;

int main(){

    int num1, num2;

    cout << "-----LER NUMEROS MULTIPLOS-----" << endl;

    cout << "Digite um numero inteiro" << endl;
    cin >> num1;
    cout << "digite outro numero inteiro." << endl;
    cin >> num2;

    if( num1%num2 == 0 || num2%num1 == 0){
    cout <<"MAS QUE COINDCIDENCIA o numero" << num1 <<"e" << num2 <<"são multiplos...LEGAL";
    }

    else {
        cout <<" EITA, o numero " << num1 <<" e " << num2 <<" não são multiplos...QUE TRISTE ";
    }

}
