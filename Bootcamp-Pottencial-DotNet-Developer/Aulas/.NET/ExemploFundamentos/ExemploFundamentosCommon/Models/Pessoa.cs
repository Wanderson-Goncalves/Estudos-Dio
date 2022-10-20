using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentosCommmon.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"\n\nOlá\nMeu nome é {Nome}, e tenho {Idade} anos.\n\n\n\n");

        }


    }
}


