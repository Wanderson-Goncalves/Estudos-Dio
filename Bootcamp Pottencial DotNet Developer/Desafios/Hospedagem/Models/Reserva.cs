namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Count()  <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                 throw new Exception($"\n\nA quantidade de {hospedes.Count()} hospedes excede a capacidade da suite que é de {Suite.Capacidade}. Favor escolher outra suite\n\n");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public  int ObterQuantidadeHospedes()
        {
          return this.Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {

            decimal descnto = (DiasReservados * Suite.ValorDiaria) * 0.10M;


            decimal valor = DiasReservados >= 10 ? (DiasReservados * Suite.ValorDiaria) - descnto : (DiasReservados * Suite.ValorDiaria);


            return valor;
        }
    }
}