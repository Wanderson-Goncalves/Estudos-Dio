using ExemploExploranddo.Models;
using System.Globalization;
using Newtonsoft.Json;

 int numero = 20;
 bool par = false;

//IF Ternario
par = numero.EhPar();

string mensagem = "O número " + numero + " " +"é "+( par? "par" : "ímpar" );
Console.WriteLine( mensagem );






















// MeuArry<int> arrayInteiro = new MeuArry<int>();

// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine(arrayInteiro[0]);

// MeuArry<string> arrayString = new MeuArry<string>();

// arrayString.AdicionarElementoArray("Testando");
// Console.WriteLine(arrayString[0]);











// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

//  variavelDinamica = "Texto";

// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");











// string conteudoArquivo = File.ReadAllText(File.ReadAllText("Arquivos/vendas.json")); 

// List<Venda>listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preco: {venda.Preco}");
// }











// var tipoAnonimo = new { Nome = "Naruto", Sobrenome = "Uzumaki", Altura = 1.80 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);










// bool? desejaReceberEmail = null;


// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)//HasValue algum valor diferente de nulo VAlue o valor
// {
//     Console.WriteLine("O usuário optou por recener e-mail.");
// }
// else
// {

//     Console.WriteLine("O usuário não repondeu ou não optou por recener e-mail.");
// }







































// DateTime dataAtual =  DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 125.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string sereializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", sereializado);
// File.WriteAllText("Arquivos/vendas.txt", sereializado);


// Console.WriteLine(sereializado);

//ISO 8601
























// 
/* IF Ternário*/

// int numero = 15;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é" + (ehPar ? "par" : "ímpar")); 






















// Pessoa p1 = new Pessoa("Leo", "Baal");

// (string nome, string sobrenome) = p1;//decustruindo em variaveis separadas
// Console.WriteLine($"{nome} {sobrenome}");












// LeituraArquivos arquivo = new LeituraArquivos();

// //var (sucesso, linhasArquivos, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");//Descarte a informação que nãoqueira usar colaca-se (_) no lugar da informação.

// if (sucesso)
// {
//     //Console.WriteLine($"Quantidades de linhas é: {quantidadeLinhas}");
//     foreach (string linha in linhasArquivos)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }











/*Tupla
POde ser usado com não quiser representar uma classe
*/

// (int, string, string, decimal) tupla = (1, "Wanderson", "Moreira", 1.83M);//representação mais usada

// Console.WriteLine($"ID: {tupla.Item1} - Nome: {tupla.Item2} - Sobrenome: {tupla.Item3} - Altura: {tupla.Item4}");

// ValueTuple<int, string, string, decimal> outrpExemploTupla = (1, "Wanderson", "Moreira", 1.83M);
// var outroExempliTuplaCreate = tupla.Create(1, "Wanderson", "Moreira", 1.83M);














































// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("MG", "Minas Gerais");
// estados.Add("ES", "Espirito Santo");
// estados.Add("BA", "Bahia");
// estados.Add("SP", "Sass");

// foreach (KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("----------------------------------------------------------------");

// estados.Remove("BA");

// estados["SP"] = "São Paulo - valor alterado";

// foreach (KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// /*Verificando um valor*/
// string chave = "BA";
// Console.WriteLine($"Vericando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else{
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }


// /*Obtendo um valor do dictionary*/

// Console.WriteLine(estados["MG"]);
















// Stack<int> pilha = new Stack<int>();

// pilha.Push(1);
// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);
// pilha.Push(5);
// pilha.Push(6);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(15);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }





















// Queue<int> fila = new Queue<int>(); // fila de inteiros

// fila.Enqueue(2);//coloca um elemento na fila
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // remove um elemento da fila sempre remove o primeiro elemento do começo da fila


// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


















//new ExemploExcecao().Metodo1();




























// try //tente fazer algo
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException ex)//catch=> pegar a exceção
// {
//     Console.WriteLine($"Ocorreu um erro naleitura do arquivo.Arquivo não encontrado. {ex.Message}");
// }

// catch (Exception ex)//catch=> pegar a exceção
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally //sempre execultado idependente de erro ou não.
// {
//     Console.WriteLine("Chegou até aqui.");
// }






















// DateTime data = DateTime.Now;

// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));//Toma cuidado com maísculas e minusculas na documentação tem todas as representações de datas
// Console.WriteLine(data.ToString("dd/-MM-yyyy HH:mm"));
// Console.WriteLine(data.ToString("yyy-MM-dd HH:mm"));
// Console.WriteLine(data.ToShortDateString());// Somente a data
// Console.WriteLine(data.ToShortTimeString());// Somente a horas


// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data:{data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida.");
// }






















// using System.Globalization;
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");//Trava o sistema numa cultura espocicfica(medas, idiomas data e horas sai com as configrações do "país espocicfico)

// decimal valorMonetario = 1453682.48M;


// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));// Modigica a cultura 
// Console.WriteLine(valorMonetario.ToString("C3"));// C3 MOdifuca as casas decimais dizendo que deve ter 3casas de pois da virgula


// double porcetagem = .3421;

// Console.WriteLine(porcetagem.ToString("P"));//Define porcetagem

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));//Define numero personalizado
















// Pessoa p1 = new Pessoa(nome:"Sakura", sobrenome:"Haruno");

// Pessoa p2 = new Pessoa(nome:"Hinata", sobrenome:"Hyuga");

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.ListarAlunos();