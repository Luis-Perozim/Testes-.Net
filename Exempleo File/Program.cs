
string caminhoOrigem = @"C:\Users\lnascimento.sjp\source\repos\TESTENET6\testeFile.txt";

//Cria o arquivo porem deixa ele aberto
//File.Create(caminhoOrigem);

Console.WriteLine("Escrevendo no arquivo...");
File.WriteAllText(caminhoOrigem, "Teste Luizin \r\n");
Console.WriteLine(" ");
Console.WriteLine("Lendo o que esta no arquivo...\n");
string conteudo = File.ReadAllText(caminhoOrigem);
Console.WriteLine("Conteúdo: " + conteudo);

Console.WriteLine($"Última modificação feita em: {File.GetLastWriteTime(caminhoOrigem)}");
Console.WriteLine($"Último acesso feito em: {File.GetLastAccessTime(caminhoOrigem)}");


Console.ReadKey();
