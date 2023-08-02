using System.Globalization;
using System.Runtime;
Produto p1 = new Produto();
p1.Nome = "Lapes decor";
p1.Preco = 2.00;
//p1.Desconto = 0.5;
//p1.PrecoFinal = p1.Preco - p1.Preco * p1.Desconto;
p1.EstoqueMinimo = 7;


p1.Exibir();










Console.ReadKey();


public class Produto
{
    private string? nome;
    public String? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }


    private double preco;
    public double Preco 
    {   get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;

        }
    }

    private double desconto = 0.5;
    public double Desconto 
    { 
        get { return desconto; }
    }

    
    public double PrecoFinal 
    { 
      get { return preco - (Preco * Desconto); }
    
    }




    public int EstoqueMinimo { get; set; }


    public void Exibir()
    {
     Console.WriteLine($"\n{Nome}, \n{Preco.ToString("c")}, \n{Desconto}, " +
                       $"\n{PrecoFinal.ToString("c")}, \n{EstoqueMinimo}");
         


    }

}


