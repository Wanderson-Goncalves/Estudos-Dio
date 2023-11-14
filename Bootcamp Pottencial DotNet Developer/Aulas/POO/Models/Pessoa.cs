using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        
        public int Idade { get; set; }

        public string Email { get; set; }
        
        

        public virtual void Apresentar()//Virtual =>fala que o método pode ser sobre escrito pela classe filha se desejar.
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
        
        
    }


    
}