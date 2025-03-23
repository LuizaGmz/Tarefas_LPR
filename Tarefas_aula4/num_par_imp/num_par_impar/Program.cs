// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("Vamos ler se um numero é impar ou par. Insira um numero");
num = Convert.ToInt32(Console.ReadLine());



if (num%2 == 0){
    Console.WriteLine($"O numero {num} é par. LEGAL  ");
}

else {
    Console.WriteLine($"Eita, o numero {num} não é par, que tritse");
}

