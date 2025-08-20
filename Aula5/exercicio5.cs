// Inicialização das variáveis
int dia = 0, semana = 0, mes = 0;  // Contadores de dias, semanas e meses
int horaspdia;                     // Horas de treino por dia (entrada do usuário)
int diapsemana = 5;                // Considera que uma semana tem 5 dias de treino
double semanapmes = 4.5;           // Aproximação de semanas por mês

int horasAtual = 0;                 // Contador de horas acumuladas de treino
int objt = 1000;                    // Objetivo total de horas

// Solicita ao usuário quantas horas treina por dia
Console.WriteLine("Quantas horas você treina por dia jovem Padawan?");
horaspdia = Convert.ToInt32(Console.ReadLine());

// Loop que simula o treino diário até atingir o objetivo
while (horasAtual < objt)
{
    horasAtual += horaspdia;  // Soma as horas de treino do dia
    dia++;                    // Incrementa o contador de dias

    // Incrementa a contagem de semanas a cada 5 dias de treino
    if (dia % diapsemana == 0)
    {
        semana++;
    }

    // Incrementa a contagem de meses a cada 4,5 semanas
    if (semana > 0 && semana % semanapmes == 0)
    {
        mes++;
    }
}

// Exibe o resultado final
Console.WriteLine("Para voce alcaçar seu objetivo de 1000 horas voce precisa de: ");
Console.WriteLine($"{dia} dias");     // Total de dias necessários
Console.WriteLine($"{semana} semanas"); // Total de semanas necessárias
Console.WriteLine($"`{mes} meses");   // Total de meses necessários

// Mensagem motivacional
Console.WriteLine("Voce consegue jovem Padawan!");
Console.WriteLine("Que a força esteja com você!");
