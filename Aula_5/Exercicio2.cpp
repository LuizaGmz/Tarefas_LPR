#include <iostream>

using namespace std;

main()
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
    float result = (float)add/div;
    cout<< result;
    return 0;
    
    /* code */
}
