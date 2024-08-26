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
            // IMPLEMENTADO
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("Capacidade Excedida");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //IMPLEMENTADO retorno de quantos hospedes.
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            //calculo implementado
            decimal valor = Suite.ValorDiaria * DiasReservados;

            //implementado desconto para quando for maior ou igual a 10
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10M;
            }
            return valor;
        }
    }
}