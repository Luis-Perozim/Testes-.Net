using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LIST
{
    public class Fonte_de_dados_Alunos
    {
       public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
               new Aluno{ Nome = "Maria", Nota = 8.75},
               new Aluno{ Nome = "Manoel", Nota = 6.95},
               new Aluno{ Nome = "Amanda", Nota = 7.25},
               new Aluno{ Nome = "Carlos", Nota = 6.55},
               new Aluno{ Nome = "Jaime", Nota = 9.25},
               new Aluno{ Nome = "João", Nota = 5.95},
               new Aluno{ Nome = "Bruno", Nota = 5.55},
               new Aluno{ Nome = "Bruna", Nota = 7.85},
               new Aluno{ Nome = "Josias", Nota = 8.3},
               new Aluno{ Nome = "Raphael", Nota = 9.13},
            };
            return alunos;

        }     

    }
}
