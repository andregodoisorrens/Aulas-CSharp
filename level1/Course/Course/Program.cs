using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //adicionar o L no final para mostrar que é long
            float n5 = 4.5f;
            double n6 = 4.5;
            bool completar = false;
            char genero = 'F';
            char caracter = '\u0048';
            string nome = "Maria Bedelho";
            object ob1 = 4.5;
            object ob2 = "Alex Mantenor";


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(completar);
            Console.WriteLine(genero);
            Console.WriteLine(caracter);
            Console.WriteLine(nome);
            Console.WriteLine(ob1);
            Console.WriteLine(ob2);


            // max and min
            /*Qulquer tipo que seja numero pode ser usado as propriedades min e max*/
            int minInt = int.MinValue;
            int maxint = int.MaxValue;

            Console.WriteLine(minInt);
            Console.WriteLine(maxint);
        }
    }
}
