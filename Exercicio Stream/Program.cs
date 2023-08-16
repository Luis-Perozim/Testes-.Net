using System.Collections.Specialized;
using System.Text;

string caminhoArquivo = @"C:\Users\lnascimento.sjp\source\repos\TESTENET6\Exercício Stream.txt";

Console.WriteLine("\nCaminho do arquivo a ser criado: ");
Console.WriteLine(caminhoArquivo);

while(true)
{
    Console.WriteLine("\nSelecione uma opção: ");
    Console.WriteLine("1-Criar arquivo.");
    Console.WriteLine("2-Gravar no arquivo");
    Console.WriteLine("3-Ler o arquivo");
    Console.WriteLine("4-Procruar texto em arquivo");
    Console.WriteLine("0-Sair");

    int opcao = Convert.ToInt32(Console.ReadLine());

    switch(opcao)
    {
        case 0:
            return;
        case 1:
            CriarArquivo(caminhoArquivo);
            break;
        case 2:
            GravarEmArquivo(caminhoArquivo);
            break;
        case 3:
            LerArquivo(caminhoArquivo);
            break;
        case 4:
            ProcurarTexto(caminhoArquivo);
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;



    }
}

static void CriarArquivo(string caminhoArquivo)
{
    try
    {
        using(FileStream Fs = new FileStream(caminhoArquivo, 
                                             FileMode.Create, 
                                             FileAccess.Write))
        {
            Console.WriteLine($"\nO arquivo {caminhoArquivo} foi criado");

        }

    }
    catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }






}
static void GravarEmArquivo(string caminhoArquivo)
{
    Console.WriteLine("Gite o texto que deseja gravar: ");
    string texto = Console.ReadLine();

    try
    {
        using (StreamWriter writer = new StreamWriter(caminhoArquivo,true))
        {
            writer.WriteLine(texto);
        }
        Console.WriteLine($"znTexto gravado no arquivo->{caminhoArquivo}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void LerArquivo(string caminhoArquivo)
{
    if(!File.Exists(caminhoArquivo))
    {
        Console.WriteLine("Não encontrado!");
        return;
    }
    try
    {
        using(StreamReader reader = new StreamReader(caminhoArquivo)) 
        {
            string linha;
            while((linha = reader.ReadLine()) !=null) 
            {
                Console.WriteLine(linha);
            
            }
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void ProcurarTexto(string caminhoArquivo)
{
    Console.WriteLine("\nDigite o texto que procura: ");
    string textoProcurado = Console.ReadLine();
    if (!File.Exists(caminhoArquivo))
    {
        Console.WriteLine("Não encontrado!");
        return;
    }


    try
    {
        bool encontrado = false;
        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            string linha;
            int numLinha = 0;
            while ((linha = reader.ReadLine()) != null)
            {
                numLinha++;
                if (linha.Contains(textoProcurado))
                {
                    Console.WriteLine($"Texo encontrado na linha {numLinha}: {linha}");
                    encontrado = true;
                }
                Console.WriteLine(linha);
            }
        }
        if(!encontrado)
        {
            Console.WriteLine("Texto não encontrado no arquivo!");
        }
    }



    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}



Console.ReadKey();
