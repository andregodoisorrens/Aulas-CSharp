using System;
using System.Globalization;

namespace Course06
{
    class Program
    {
        static void Main(string[] args)
        {
            //while

            /*
            Console.WriteLine("Digite um numero:");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n >= 0.0)
            {
                double raiz = Math.Sqrt(n);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro numero:");
                n = double.Parse(Console.ReadLine());

            };

            Console.WriteLine("Numero Negativo!!!");
            */

            //for
            Console.Write("Digite a quantidade de numeros a serem somado: ");
            int x = int.Parse(Console.ReadLine());
            double soma = 0;

            for (int i = 1; i <= x; i++)
            {
                Console.Write("Valor : #{0}: ", i);
                double y = double.Parse(Console.ReadLine());
                soma += y;
            }
            Console.WriteLine("O valor da soma foi: " + soma);

        }
    }
}
