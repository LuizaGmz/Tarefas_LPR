using System;

public class Funcionario
{
    public string nome;
    public double salarioBrut;
    public double salarioLiq;
    public double imposto;

    public double calcImposto()
    {
        if (salarioBrut < 2000)
        {
            return salarioBrut * 0.1;
        }
        else if (salarioBrut <= 3000)
        {
            return salarioBrut * 0.15;
        }
        else
        {
            return salarioBrut * 0.2;
        }

    }

    public double calcSalarioLiq()
    {
        imposto = calcImposto();
        return salarioBrut - imposto;
    }

    public void exibFunc()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Salário Bruto: {salarioBrut}");
        Console.WriteLine($"Imposto: {imposto}");
        Console.WriteLine($"Salário Líquido: {salarioLiq}");
    }
    
    public void aumentarSalario(double perc)
    {
        salarioBrut += salarioBrut * (perc / 100);
    }

  


}

class Program
{
    static void Main()
    {
        Funcionario func = new Funcionario();

        Console.WriteLine("Digite o nome do funcionário:");
        func.nome = Console.ReadLine();

        Console.WriteLine("Digite o salário bruto do funcionário:");
        func.salarioBrut = Convert.ToDouble(Console.ReadLine());

        func.salarioLiq = func.calcSalarioLiq();
        func.exibFunc();

        Console.WriteLine("Digite a porcentagem de aumento salarial:");
        double perc = Convert.ToDouble(Console.ReadLine());
        func.aumentarSalario(perc);

        func.salarioLiq = func.calcSalarioLiq();
        Console.WriteLine("Após o aumento salarial:");
        func.exibFunc();
    }
}