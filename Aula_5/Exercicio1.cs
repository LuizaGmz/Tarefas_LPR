
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);
int tentativa = 0;
int numero = 0;


Console.WriteLine("Tente adivinhar o numero entre 1 e 100");
numero = Convert.ToInt32(Console.ReadLine());
tentativa++;

do {
    if (numero == valorInteiro) {
        Console.WriteLine("Parabéns! Você acertou!");
        Console.WriteLine("Você tentou " + tentativa + " vezes");
        break;
    } else if (numero < valorInteiro) {
        Console.WriteLine("O número é maior que " + numero);
    } else {
        Console.WriteLine("O número é menor que " + numero);
    }
    Console.WriteLine("Tente novamente");
    numero = Convert.ToInt32(Console.ReadLine());
    tentativa++;
}

while (numero != valorInteiro); {
    Console.WriteLine("Parabéns! Você acertou!");
    Console.WriteLine("Você tentou " + tentativa + " vezes");
}


