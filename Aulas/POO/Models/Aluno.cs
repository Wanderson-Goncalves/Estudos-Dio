using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Aluno : Pessoa// herdando atriburos da classe pessoa
    {
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()//Override => esta sobreescrevendo o metodo apresetar da classe pai
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}.");

        }
        
        
    }
}