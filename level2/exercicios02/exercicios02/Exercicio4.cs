using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios02
{
    class Exercicio4
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void NovoSalario(double porcentagem)
        {
            SalarioBruto = (SalarioBruto * porcentagem / 100) + SalarioBruto;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido();
        }
    }
}
