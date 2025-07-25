// See https://aka.ms/new-console-template for more information
int dia = 0, semana = 0, mes = 0;
int horaspdia;
int diapsemana = 5;
double semanapmes = 4.5;

int horasAtual = 0;
int objt = 1000;

Console.WriteLine("Quantas horas você treina por dia jovem Padawan?");
horaspdia = Convert.ToInt32(Console.ReadLine());



while (horasAtual < objt)
{
    horasAtual += horaspdia;
    dia++;

    if (dia % diapsemana == 0)
    {
        semana++;
    }
    if (semana > 0 && semana % semanapmes == 0)
    {
        mes++;
    }
  
}
  Console.WriteLine("Para voce alcaçar seu objetivo de 1000 horas voce precisa de: ");
    Console.WriteLine($"{dia} dias");
    Console.WriteLine($"{semana} semanas");
    Console.WriteLine($"`{mes} meses");
   
    Console.WriteLine("Voce consegue jovem Padawan!");
    Console.WriteLine("Que a força esteja com você!");



