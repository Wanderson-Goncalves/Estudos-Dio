namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }       

        protected string Modelo {get; set;}
        protected string IMEI {get; set;}
        protected int Memoria {get; set;}

        // public Smartphone()
        // {            
        // }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
         public void Apresentar()
        {
            Console.WriteLine($" Novo Smartphone \n Numero: {Numero}\n Modelo: {Modelo}\n Memoria: {Memoria}\n Imei: {IMEI} \n");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}