using Herança;
using System.Runtime.InteropServices;

Console.WriteLine("\nConta corrente: Número; 123 Titular: Luis");
Conta conta = new Conta();
conta.Numero = 123;
conta.Titular = "Luis";

Console.WriteLine("Depósitode R$ 5000,00");
conta.Depositar(5000);
Console.WriteLine("Sacando R$ 1000,00");
conta.Sacar(1000);
Console.WriteLine($"Saldo da conta: {conta.Saldo.ToString("c")}");


Console.ReadKey();

Console.WriteLine("\nConta Poupança: Número; 123 Titular: Luis");
ContaPoupanca contapoupanca = new();
contapoupanca.Numero = 123;
contapoupanca.Titular = "Luis";

Console.WriteLine("Deposito de R$1000,00");
contapoupanca.Depositar(1000);
Console.WriteLine($"Saldo da ContaPoupanca: {contapoupanca.Saldo.ToString("c")}");

Console.WriteLine("Saque de R$100,00");
contapoupanca.Sacar(100);
Console.WriteLine($"Saldo da ContaPoupanca: {contapoupanca.Saldo.ToString("c")}");

Console.ReadKey();


Console.WriteLine("\nConta Investimento: Número; 123 Titular: Luis");
ContaInvest containvest = new();
containvest.Numero = 123;
containvest.Titular = "Luis";

Console.WriteLine("Deposito de R$ 10000,00");
containvest.Depositar(10000);
Console.WriteLine($"Saldo da Conta Inestimento: {containvest.Saldo.ToString("c")}");
Console.WriteLine("Saque de R$1000");
containvest.Sacar(1000);
Console.WriteLine($"Saldo da ContaPoupanca: {containvest.Saldo.ToString("c")}");



