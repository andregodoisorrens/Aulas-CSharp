using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios02
{
    class Exercicio3
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return Largura + Largura + Altura + Altura;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        public override string ToString()
        {
            return "Area: " + Area() + ", Perimetro: " + Perimetro() + ", Diagonal: " + Diagonal();
        }

    }
}
