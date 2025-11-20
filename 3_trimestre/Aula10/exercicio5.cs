using System;
using System.Collections.Generic;

class Cliente
{
    public string Nome { get; set; }
    public List<Reserva> Reservas { get; set; } = new List<Reserva>();

    public Cliente(string nome)
    {
        Nome = nome;
    }

    
    public void AdicionarReserva(Reserva r)
    {
        r.Cliente = this; 
        Reservas.Add(r);
    }

    
    public void ListarReservasFuturas()
    {
        Console.WriteLine($"Reservas futuras de {Nome}:");

        foreach (var r in Reservas)
        {
            if (r.DataReserva > DateTime.Now)
            {
                Console.WriteLine($" - {r.Descricao} em {r.DataReserva}");
            }
        }
    }
}

class Reserva
{
    public string Descricao { get; set; }
    public DateTime DataReserva { get; set; }

    // d) reserva referencia o cliente
    public Cliente Cliente { get; set; }

    public Reserva(string descricao, DateTime data)
    {
        Descricao = descricao;
        DataReserva = data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cliente c1 = new Cliente("Sparky");

        Reserva r1 = new Reserva("Reserva Hotel", DateTime.Now.AddDays(2));
        Reserva r2 = new Reserva("Reserva Restaurante", DateTime.Now.AddHours(-4));
        Reserva r3 = new Reserva("Reserva Cinema", DateTime.Now.AddDays(5));

        c1.AdicionarReserva(r1);
        c1.AdicionarReserva(r2);
        c1.AdicionarReserva(r3);

        c1.ListarReservasFuturas();

        Console.ReadLine();
    }
}
