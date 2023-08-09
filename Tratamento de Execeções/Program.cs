
try
{
	Console.WriteLine("Acessando o arquivo TESTENET6.sln em https://github.com/Luis-Perozim/Testes-.Net\n");
	Console.WriteLine("Informe o nome do arquivo.");
	string arquivo = Console.ReadLine();
	Console.WriteLine("Informe o URL do site");
	string url = Console.ReadLine();
	Console.WriteLine("Agurde....");

	HttpClient client = new HttpClient();
	HttpResponseMessage response = client.GetAsync(url + "/" + arquivo).Result;

	if (response.IsSuccessStatusCode)
	{
		Console.WriteLine("Acesso com sucesso!");
		Console.WriteLine("Código de status: " + response.StatusCode);
	}
	else
	{
		throw new HttpRequestException("ERRO: " + (int)response.StatusCode);
	}

}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
	Console.WriteLine("Página não encontrada.");
}
catch(HttpRequestException ex) when(ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado.");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Requisição inválida.");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno do servidor.");
}
catch(Exception ex)
{
	Console.WriteLine("ERRO: " + ex.Message);
}
finally
{
	Console.WriteLine("Fim do processamento.");
}


Console.ReadKey();
