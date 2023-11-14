namespace ExemploFundamentosCommon;
public class Class1
{
    /// <summary>
    /// Representa uma pessoa física (pode colocar o que cada classe representa)
    /// </summary>
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string NomeRepresetanteLegalDaPessoaFisica { get; set; }

    /// <summary>
    /// Faz a pessoa se apresentar, dizendo seu nome e idade
    /// </summary>
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
    }
}
