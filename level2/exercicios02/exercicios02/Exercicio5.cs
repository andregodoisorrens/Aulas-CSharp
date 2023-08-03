using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios02
{
    class Exercicio5
    {

        public String Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal() {
            return N1 + N2 + N3;
        }

        public bool Aprovado()
        {
            if(NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }

    }
}
