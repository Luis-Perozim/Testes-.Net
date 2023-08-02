IControle d = new Demo();
d.Nome = "teste";
d.Desenhar();
d.Exibir();



Console.ReadKey();

interface IControle
{
    void Desenhar();
    string Nome { get; set; }
    public void Exibir()
    {
        Console.WriteLine("Teste...");
    }

}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string Nome { get; set; } = string.Empty;

    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
        
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }
}