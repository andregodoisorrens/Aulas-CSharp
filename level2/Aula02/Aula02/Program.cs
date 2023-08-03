using System;
using System.Globalization;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre p valor do Raio: ");
            double Raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(Raio);
            double Vol = Calculadora.Volume(Raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
