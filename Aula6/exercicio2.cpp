#include <iostream>
using namespace std;

void exercicio1() 
{
    int quant, num, cont = 0, div = 0, add = 0;

    cout << "Digite a quastidade de numeros: ";
    cin >> quant;

    while (cont < quant)
    {
        cout << "Digite o: " << cont + 1 << " numero: ";
        cin >> num;

        if (num % 2 == 0)
        {
            add += num;
            div++;
        }

        cont++;
    }
    float result = (float)add / div;
    cout << result;
}

void exercicio2() // soma dos números ímpares múltiplos de 3 entre 50 e 500
{
    int soma = 0;

    for (int i = 50; i <= 500; i++)
    {
        if (i % 3 == 0 && i % 2 == 1)
        {
            soma += i;
        }
    }
    cout << "A soma dos números ímpares múltiplos de 3 entre 50 e 500 é: " << soma << endl;
}

void exercicio3() // média dos números pares 
{
    int num, cont = 0, div = 0, add = 0;

    cout << "Digite a quantidade de numeros: ";
    cin >> num;

    while (cont < num)
    {
        cout << "Digite o: " << cont + 1 << " numero: ";
        cin >> num;

        if (num % 2 == 0)
        {
            add += num;
            div++;
        }

        cont++;
    }
    float result = (float)add / div;
    cout << result;
}

int main() // menu principal
{

    int opcao;
    cout << "MENU PRINCIPAL" << endl;
    cout << "ESCOLHA UMA OPCAO" << endl;
    cout << "exercicio 1" << endl;
    cout << "exercicio 2" << endl;
    cout << "exercicio 3" << endl;
    cin >> opcao;

    switch (opcao)
    {
    case 1:
        exercicio1(); // soma dos números pares
        break;
    case 2:
        exercicio2(); // soma dos números ímpares múltiplos de 3 entre 50 e 500
        break;
    case 3:
        exercicio3(); // média dos números pares
        break;
    default:
        cout << "Opcao invalida!" << endl;
    }
}
