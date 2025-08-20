#include <iostream>  // Inclui a biblioteca padrão de entrada e saída
using namespace std; // Permite usar cout e cin sem o prefixo std:: 

int main()
{
    int soma = 0; // Variável para armazenar a soma dos números desejados

    // Laço que percorre todos os números de 50 a 500
    for (int i = 50; i <= 500; i++)
    {
        // Verifica se o número é múltiplo de 3 e ímpar
        if (i % 3 == 0 && i % 2 == 1){
            soma += i; // Adiciona o número à soma se a condição for verdadeira
        }
    }

    // Exibe o resultado da soma
    cout << "A soma dos números ímpares múltiplos de 3 entre 50 e 500 é: " << soma << endl;

    return 0; // Indica que o programa terminou corretamente
}

/* code */
