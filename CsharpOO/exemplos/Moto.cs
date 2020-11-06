using System;

namespace CsharpOO2
{
    public class Moto : Veiculo 
    {
        public Moto(string placa)
            : base(placa)
        {
        }
        public Moto()
        {
            
        }
        public override int QuantidadeDePneus()
        {
            return 2;
        }

        public int numeroQuedas {get;set;}
    }
}
