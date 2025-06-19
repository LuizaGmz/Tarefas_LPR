#include <iostream>

using namespace std;

int main()
{

    int soma = 0;

    for (int i = 50; i <= 500; i++)
    {
        if (i % 3 == 0 && i % 2 == 1){
            soma += i;
        }
    
    }
    cout << "A soma dos números ímpares múltiplos de 3 entre 50 e 500 é: " << soma << endl;

    return 0;
}

/* code */
