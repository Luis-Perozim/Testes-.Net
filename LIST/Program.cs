
using LIST;

List<Aluno> alunos = Fonte_de_dados_Alunos.GetAlunos();

ExibirAlunos(alunos);

Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75 };
Aluno mario = new Aluno() { Nome = "Mario", Nota = 8.95 };
alunos.Add(bia);
alunos.Add(mario);

ExibirAlunos(alunos);


var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAlunos(alunos);


var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList();

ExibirAlunos(listaOrdenada);


var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);
Console.WriteLine("\nAlunos com nota maior que 8-");

foreach (var item in alunosNotaOito)
{
    Console.WriteLine($"{item.Nome}\t{item.Nota}");
}


Console.ReadKey();

static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de alunos\n");
    Console.WriteLine("\nNome \tNota");

    var somaNota = 0.0;


    foreach (Aluno al in alunos)
    {
        Console.WriteLine($"{al.Nome}\t{al.Nota}\n");
        somaNota += al.Nota;
    }

    var mediaNotas = somaNota / alunos.Count();
    Console.WriteLine($"\nMédia das notas : {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de alunos : {alunos.Count()}");
}