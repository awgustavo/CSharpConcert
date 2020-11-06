using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsharpOO2;


namespace CsharpOO
{

    class Program
    {
        public static void VerificarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine("Placa do veiculo: " + veiculo.ToString(true));
        }

        public static List<T> ImportarVeiculos<T>(string CSVPath)
            where T : Veiculo, new()
        {
            var todasAsLinhas = File.ReadAllLines(CSVPath);
            List<T> veiculos = todasAsLinhas.Select(m => {
                var infCar = m.Split(";");
                var car = new T();
                car.placa = infCar[0];
                car.cor = infCar[1];
                car.marca =infCar[2];
                car.modelo = infCar[3];
                return car;
            }).ToList<T>();
            return veiculos;
        }

        public static void Main(string[] args)
        {


            List<Carro> veiculos  = ImportarVeiculos<Carro>("C:/dev/csharp/CsharpOO/csv/veiculos.csv");
            foreach(var veiculo in  veiculos)
            {
                VerificarVeiculo(veiculo);
            }

            Program.EscopoDeClasse();

            new Program().EscopoDeObjeto();
        }

        public void EscopoDeObjeto()
        {
            
        }

        public static void EscopoDeClasse()
        {
            
        }
    }
}
