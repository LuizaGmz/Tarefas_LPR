#include <iostream>  // Biblioteca padrão para entrada e saída
using namespace std; // Permite usar cout e cin sem o prefixo std:: 

main()  // Função principal do programa
{
    int quant, num, cont = 0, div = 0, add = 0;  
    // quant -> quantidade de números que o usuário quer digitar
    // num -> número digitado pelo usuário
    // cont -> contador de iterações
    // div -> contador de números pares (para divisão)
    // add -> soma dos números pares

    cout << "Digite a quastidade de numeros: ";  
    cin >> quant;  // Lê a quantidade de números que o usuário deseja digitar

    // Loop para ler cada número
    while (cont < quant)
    {
        cout << "Digite o: " << cont + 1 << " numero: ";
        cin >> num;  // Lê um número do usuário

        // Verifica se o número é par
        if (num % 2 == 0)
        {
            add += num;  // Soma os números pares
            div++;       // Incrementa o contador de números pares
        }

        cont++;  // Incrementa o contador do loop
    }

    float result = (float)add / div;  
    // Calcula a média dos números pares (casting para float para divisão decimal)

    cout << result;  // Exibe o resultado da média
    return 0;        // Indica que o programa terminou corretamente

    /* code */
}
