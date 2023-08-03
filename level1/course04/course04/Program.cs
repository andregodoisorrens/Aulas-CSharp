using System;
using System.Globalization;

namespace course04
{
    class Program
    {
        static void Main(string[] args)
        {
            //course 4
            //aula 04
            /*
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            double n3 = 17 % 3;
            double n4 = 10.0 / 8.0;

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            */

            //course 5
            //aula 5

            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');
            string p1 = v[0];
            string p2 = v[1];
            string p3 = v[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            */

            //course 6
            //aula 6
            /*
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));
            */

            //course 07
            //Aula 07
            /*
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Console.WriteLine("--------------------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
            */

            //Course 07
            //aula 07
            /*
            bool c1 = 2 > 3 || 4 != 5;
            bool c2 = !(2 > 3) && 4 != 5;
            //c1 - se 2 for maior que 3 - resultado -> true ou 4 diferetne de 5 -> true
            //c2 - se 2 for maior que 3 -> resultado true (pois, o não altera o resultado para true, vice e versa) e 4 é diferente de 5 -> true

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("----------------------------------------");

            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;
            //c3 - se 5 for maior que 10 -> false
            //c4 - c3 e c2 não são iguais pois c3 é falso e c2 é verdadiro resulato -> false, entretanto o c1 é verdadeiro e o c2 e c3 é falso resultado -> true 

            Console.WriteLine(c3);
            Console.WriteLine(c4);
            */

            //course 08
            //aula 08

            //int x = 10;
            /*Console.WriteLine("Bom Dia!");
            if (x > 5)
            {
                Console.WriteLine("Boa Tarde!");
            }
            Console.WriteLine("Boa Noite!");
            
            Console.WriteLine("Entre com um numero inteiro: ");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            

            Console.WriteLine("Qual o horário atual?");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12)
            {
                Console.WriteLine("Bom Dia");
            }
            else if(hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa Tarde");
            }
            else
            {
                Console.WriteLine("Boa Noite");
            }
            */
            /*
            int x; //não foi inserido o valor ou seja não aparece

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if(preco > 100)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
            */

            // funções sintaxe

            Console.WriteLine("Digite três Numeros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

        }

        static int Maior(int n1, int n2, int n3)
        {
            int m;
            if (n1 > n2 && n1 > n3)
            {
                m = n1;
            }
            else if (n2 > n3)
            {
                m = n2;
            }
            else
            {
                m = n3;
            }
            return m;
        }
    }
}
