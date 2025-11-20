using System;

public class Retangulo
{
    public double largura;
    public double altura;

    public double CalcArea()
    {
        return largura * altura;
    }

    public double CalcPerimetro()
    {
        return 2 * (largura + altura);
    }


}

class Program
{
    static void Main()
    {
        Retangulo ret = new Retangulo();

        Console.WriteLine("Digite a largura do retangulo:");
        ret.largura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a altura do retangulo:");
        ret.altura = Convert.ToDouble(Console.ReadLine());

        double area = ret.CalcArea();
        double perimetro = ret.CalcPerimetro();

        Console.WriteLine($"Area do retângulo: {area}");
        Console.WriteLine($"Perimetro do retângulo: {perimetro}");
    }
}