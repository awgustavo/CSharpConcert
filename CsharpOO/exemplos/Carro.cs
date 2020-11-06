using System;

namespace CsharpOO2
{
    public class Carro : Veiculo 
    {
        public Carro(string placa)
            : base(placa)
        {
            
        }

        public Carro()
        {
            
        }

        public override int QuantidadeDePneus()
        {
            return 4;
        }

        public int numeroLugares {get;set;}
    }
}
