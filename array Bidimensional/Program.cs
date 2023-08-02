
string[,] alunos = new string[2, 5];
Console.WriteLine("{Maria, Paulo, Marta, Pedro, Carlos}");
Console.WriteLine("{Silvia, Pedro, Alicia, Manoel, Paula}\n");




for (int i = 0; i < alunos.GetLength(0); i++)
{
	for (int j = 0; j < alunos.GetLength(1); j++)
	{
		Console.WriteLine($"informe o valor para o elemento na posição [{i},{j}]");
		alunos[i, j] = Console.ReadLine();
	}

}

Console.WriteLine("\nConteúdo do Array alunos\n");
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"[{i},{j}] = {alunos[i,j]}\t");
    }

}
Console.ReadKey();