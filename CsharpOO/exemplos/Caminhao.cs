using System;

namespace CsharpOO2
{
    public class Caminhao : Veiculo 
    {
        public Caminhao(string placa)
            : base(placa)
        {
        }
        public Caminhao()
        {
        }

        public override int QuantidadeDePneus()
        {
            return numeroEixos * 2;
        }

        public int numeroEixos {get;set;}
    }
}
