using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome): base(nome)
        {
            
        }
        public double Salario { get; set; }

         public override void Apresentar()//Override => esta sobreescrevendo o metodo apresetar da classe pai
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou professor e ganho {Salario}.");

        }
        
        
    }
}