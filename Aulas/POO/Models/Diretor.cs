using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome) : base(nome)
        {
        }

        public override void Apresentar()//Override => esta sobreescrevendo o metodo apresetar da classe pai
        {
            Console.WriteLine($"Diretor");

        }
        
    }
}