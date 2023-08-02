using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class ContaInvest : Conta
    {
        public override double Juros { get; set; } = 0.009;
        public double imposto { get; set; } = 0.001;


        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo -valor - (Saldo*(decimal)imposto);
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
                return Saldo;
            }

        }
    }
}
