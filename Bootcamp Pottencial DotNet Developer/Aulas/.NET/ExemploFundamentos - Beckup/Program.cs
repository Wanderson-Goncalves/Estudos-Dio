
using Pessoas;
using Models;

string opcao;
bool exebirMenu = true;

while (exebirMenu)
{
    Console.Clear();
    Console.WriteLine("Digete a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");


    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar de cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar de cliente");
            exebirMenu = false;//Saí do while
           // Environment.Exit(0);//encerra o programa inteiro
            break;

        default:

            Console.WriteLine("Opção invalida");
            break;



    }



}




























//int soma = 0, numero = 0;
// do
// {
//     Console.WriteLine("\n Digite um número. (0 para parar)\n");


//     soma += numero;


// } while (numero != 0);

// Console.WriteLine($"\n Total da soma dos números digitados é: {soma}");



















































// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);

// calc.Subtrair(35,4);

// calc.Divisao(10, 5);

// calc.Multiplicao(10, 5);

// calc.Potencia(3, 3);

// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// calc.RaizQuadrada(4);





























// bool choveu = true;
// bool estaTarde = true;


// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar ouro dia");
// }













// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");

// }
// else
// {
//     Console.WriteLine("Reprovado");
// }






















// bool maiorDeIdade = true;
// bool possuiAutorizacaoDoReponsavel = false;

// if (maiorDeIdade || possuiAutorizacaoDoReponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada.");
// }






// Console.WriteLine("Digite uma letra \n");
// string letra = Console.ReadLine();//ReadLine => O console espera digitar e pertat ENTER para continuar

// switch (letra)
// {

//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":

//         Console.WriteLine(" Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }






















// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome ="Wanderson";
// pessoa1.Idade = 35;

// pessoa1.Apresentar();

