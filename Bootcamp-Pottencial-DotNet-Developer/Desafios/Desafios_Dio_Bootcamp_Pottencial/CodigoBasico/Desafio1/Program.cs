using System;

class DIO
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int numero = Convert.ToInt32(Console.ReadLine());
        int produto = 1, soma = 0;
        while (numero > 0)
        {
            int l = numero % 10;
            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            produto *= l;
            soma += l;
            numero /= 10;
        }

        Console.WriteLine(produto - soma);
    }
}