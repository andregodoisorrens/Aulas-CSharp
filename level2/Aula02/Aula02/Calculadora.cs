using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    class Calculadora
    {

        public static double PI = 3.14;

        public static double Circunferencia(double R)
        {

            return 2.0 * PI * R;

        }

        public static double Volume(double R)
        {
            return 4.00 / 3.00 * PI * Math.Pow(R, 3);
        }

    }
}
