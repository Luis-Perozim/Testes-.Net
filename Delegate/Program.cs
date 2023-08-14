
using Delegate;

var listaDePessoas = Pessoa.GetPessoas();

Action<Pessoa> imprimirNome = p => Console.WriteLine(p.Nome + " " + p.Idade);
listaDePessoas.ForEach(imprimirNome);

Console.WriteLine("Pessoas com mais de 18 anos:");

Predicate<Pessoa> filtrarIdeadeMaiorQue18 = p => p.Idade > 18;
var pessoasMaioresDe18Anos = listaDePessoas.FindAll(filtrarIdeadeMaiorQue18);
pessoasMaioresDe18Anos.ForEach( p => Console.WriteLine(p.Nome + " " + p.Idade));

Console.WriteLine("Pessoas com mais anos:");
Func<Pessoa,int> obterIdade = p => p.Idade;
int idadeMaxima = listaDePessoas.Max(obterIdade);
var pessoaMaisVelha = listaDePessoas.Find(p=> p.Idade == idadeMaxima);
Console.WriteLine("A pessoa mais velha é: " + pessoaMaisVelha.Nome + " idade: " + pessoaMaisVelha.Idade);

Console.ReadKey();