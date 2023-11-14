using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentosCommmon.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro parasomar</param>
        /// <param name="y">O segundo número inteiro parasomar</param>
        /// 
        public int Somar(int x, int y)
        {

            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        /// <summary>
        /// Realiza uma subtração de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro para subtrair</param>
        /// <param name="y">O segundo número inteiro para subtrair</param>
        /// 
        /// <returns>Retorna a subtração de x e y</returns>
        public int Subtrair(int x, int y)
        {

            //Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
        }

        public void Multiplicao(int x, int y)
        {

            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Divisao(int x, int y)
        {

            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno(double angulo)
        {

            double radiano = angulo * (Math.PI / 180);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {

            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {

            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Sqrt(x)}");
        }


    }



}