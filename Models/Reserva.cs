namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public decimal Desconto { get; set; }
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int capacidadeMaxima = 3;
            
            if (hospedes.Count <= capacidadeMaxima)
            {
                Console.WriteLine("A capacidade é suficiente para receber os hóspedes.");
             
                Hospedes = hospedes;                  
            }

            else
            {    
                 Console.WriteLine("Capacidade insuficiente para receber os hóspedes.");
                
                 throw new Exception ("Capacidade apenas 2.");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes?.Count?? 0;
           
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
               Desconto = valor *0.1m;

               valor -= Desconto;                 
            }

            return valor;
        }
    }
}