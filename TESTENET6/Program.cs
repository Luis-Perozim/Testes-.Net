using System.Globalization;
Console.WriteLine("TESTE MÉTODOS .Net");

var aluno = new Aluno();

Console.WriteLine("Nome: ");
aluno.Nome =Console.ReadLine();

Console.WriteLine("Idade: ");
aluno.Idade = (Console.ReadLine());

Console.WriteLine("Matéria: ");
aluno.Materia = Console.ReadLine();


Console.WriteLine("Nota: ");
aluno.Nota = Convert.ToInt32(Console.ReadLine());

Curso curso = new();
curso.Resultado(aluno.Nome, aluno.Idade, aluno.Materia, aluno.Nota);

 



Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public string?Idade;
    public string? Materia;
    public int Nota;
}

public class Curso
{
    public void Resultado(string nome, string idade, string materia, int nota)
    {
        Console.WriteLine($"\n O Aluno {nome}; Idade {idade}  na máteria de {materia} com a nota {nota}");
        if(nota>=7)  
        {
            Console.WriteLine("Foi APROVADO");
        }
        else
        {
            Console.WriteLine("Foi REPROVADO");
        }



    }

    
}