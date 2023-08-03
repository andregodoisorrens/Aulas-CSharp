using System;

namespace Course03
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversão implicita é quando vc muda de um tipo para outro que tambem é compativel
            //neste link tem a tabela de variáveis compativeis:
            //https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/numeric-conversions
            //exemplos de casting
            //exemplo 1
            double a;
            float b;
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            //exemplo 2
            double c;
            int d;
            c = 5.1;
            d = (int)c;
            Console.WriteLine(d);

            //exemplo 3
            int e = 5;
            int f = 2;
            double resultado = (double)e / f;
            Console.WriteLine(resultado);
        }
    }
}
