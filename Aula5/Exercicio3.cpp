#include <iostream>  // Biblioteca padrão para entrada e saída
using namespace std; // Permite usar cout e cin sem o prefixo std:: 

int main()
{
    int i, result, soma = 0;  // Declara variáveis: i (número do usuário), result (quadrado de i), soma (soma dos dígitos do quadrado)
    
    cout << "Digite um numero: ";  // Solicita ao usuário que digite um número
    cin >> i;                      // Lê o número digitado e armazena em i

    result = i * i;  // Calcula o quadrado do número e armazena em result

    // Laço para somar os dígitos do quadrado
    while (result > 0){
        soma += result % 10;  // Soma o último dígito de result à variável soma
        result /= 10;         // Remove o último dígito de result
    }

    // Exibe o resultado final
    cout << "A soma dos digitos ao quadrado do numero " << i << " é: " << soma << endl;

    return 0;  // Indica que o programa terminou corretamente
}
