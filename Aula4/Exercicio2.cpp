#include <iostream>
// Inclui a biblioteca de entrada e saída padrão

using namespace std;
// Permite usar cout, cin, endl sem precisar escrever std::

int main(){
    // Função principal do programa, ponto de entrada

    int num1, num2;
    // Declara duas variáveis inteiras para armazenar os números digitados pelo usuário

    cout << "-----LER NUMEROS MULTIPLOS-----" << endl;
    // Mostra um cabeçalho no console

    cout << "Digite um numero inteiro" << endl;
    cin >> num1;
    // Solicita ao usuário o primeiro número e lê o valor digitado

    cout << "digite outro numero inteiro." << endl;
    cin >> num2;
    // Solicita ao usuário o segundo número e lê o valor digitado

    if( num1%num2 == 0 || num2%num1 == 0){
        // Verifica se num1 é múltiplo de num2 ou vice-versa usando o operador módulo (%)
        cout <<"MAS QUE COINDCIDENCIA o numero" << num1 <<"e" << num2 <<"são multiplos...LEGAL";
        // Mensagem caso sejam múltiplos
    }
    else {
        // Caso os números não sejam múltiplos
        cout <<" EITA, o numero " << num1 <<" e " << num2 <<" não são multiplos...QUE TRISTE ";
        // Mensagem caso não sejam múltiplos
    }

}
// Fim do programa
