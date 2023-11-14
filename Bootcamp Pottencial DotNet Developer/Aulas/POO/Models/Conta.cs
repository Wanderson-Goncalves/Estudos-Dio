using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public abstract class Conta // classe abstrata
    {
        protected decimal saldo; // protegido contra alteração externa mas as classes filhas pode alterar

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }


    }
}