

int qt = int.Parse(Console.ReadLine());

string[] v = new string[2];

// TODO: Crie as outras condições necessárias para a resolução do desafio:
for (int i = 0; i < qt; i++)
{
    Console.WriteLine("Digite os valores de A e B.");



    v[0] = Console.ReadLine();
    v[1] = Console.ReadLine();

    string a = v[0];
    string b = v[1];



    if (b.Length > a.Length)
    
        Console.WriteLine("nao encaixa");
    

    //Determinado se minha string b ocorre no final da string a
    else if (a.EndsWith(b))
    
        Console.WriteLine("encaixa");
    

    else
    
        Console.WriteLine("nao encaixa");
    

}

