Random numAleatorio = new Random();  
// Cria um gerador de números aleatórios

int valorInteiro = numAleatorio.Next(1,100);  
// Gera um número aleatório entre 1 e 99 (o limite superior 100 não é incluído)

int tentativa = 0;  
// Contador de tentativas do usuário

int numero = 0;  
// Variável para armazenar o número digitado pelo usuário

Console.WriteLine("Tente adivinhar o numero entre 1 e 100");  
// Mensagem inicial

numero = Convert.ToInt32(Console.ReadLine());  
// Lê o palpite do usuário e converte para inteiro

tentativa++;  
// Incrementa o número de tentativas

do {
    if (numero == valorInteiro) {
        // Se o número digitado for igual ao número aleatório
        Console.WriteLine("Parabéns! Você acertou!");
        Console.WriteLine("Você tentou " + tentativa + " vezes");
        break;  // Sai do loop
    } else if (numero < valorInteiro) {
        // Se o número digitado for menor que o número aleatório
        Console.WriteLine("O número é maior que " + numero);
    } else {
        // Se o número digitado for maior que o número aleatório
        Console.WriteLine("O número é menor que " + numero);
    }
    
    Console.WriteLine("Tente novamente");  
    // Solicita uma nova tentativa

    numero = Convert.ToInt32(Console.ReadLine());  
    // Lê o novo palpite do usuário

    tentativa++;  
    // Incrementa o contador de tentativas

} while (numero != valorInteiro);  
// Continua enquanto o número digitado for diferente do número aleatório

// Estas linhas fora do loop são redundantes, porque o acerto já é tratado dentro do do-while
Console.WriteLine("Parabéns! Você acertou!");
Console.WriteLine("Você tentou " + tentativa + " vezes");
