using System;
using System.Globalization;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double xA, xB, xC, yA, yB, yC, P, areaX, areaY;

            Console.WriteLine("Entre com as medias do triangulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medias do triangulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            P = (xA + xB + xC) / 2;
            areaX = Math.Sqrt(P * (P - xA) * (P - xB) * (P - xC));

            P = (yA + yB + yC) / 2;
            areaY = Math.Sqrt(P * (P - yA) * (P - yB) * (P - yC));

            Console.WriteLine("Area do X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
            */

            // MELHOR REPRESENTAÇÃO

            /*
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medias do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medias do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double P = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(P * (P - x.A) * (P - x.B) * (P - x.C));

            P = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(P * (P - y.A) * (P - y.B) * (P - y.C));

            Console.WriteLine("Area do X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
            */

            // BENEFICIOS, APROVEITAMENTOS E DELEGAÇÃO
            /*
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medias do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medias do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Area do X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
            */

        }

    }
}
