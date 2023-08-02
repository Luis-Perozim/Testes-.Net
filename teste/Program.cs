using System.Numerics;

Console.WriteLine("TESTE EXERCICIOS");

ContaCorrente c1 = new ContaCorrente();
c1.Conta = 1569;
c1.Nome = "BIG JOHN";
//c1.Juros = 3.99f;

ContaCorrente.Juros = 4.25f;

ContaCorrente c2 = new ContaCorrente();

c2.Conta = 1469;
c2.Nome = "BIG JOE";
//c2.Juros = 4.55f;

Console.WriteLine($"Cliente: {c1.Nome} Conta: {c1.Conta} Juros Anual: {c1.JurosAnual()}");
Console.WriteLine($"Cliente: {c2.Nome} Conta: {c2.Conta} Juros Anual: {c2.JurosAnual()}");


Console.ReadKey();


public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;



    public float JurosAnual()
    {
       return Juros * 12; 
    
    
    }
}