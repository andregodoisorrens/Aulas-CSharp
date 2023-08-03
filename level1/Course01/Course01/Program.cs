using System;
using System.Globalization;

namespace Course01
{
    class Program
    {
        static void Main(string[] args)
        {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("Bom Dia!");
            Console.Write("Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome +  " tem " + idade + "anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + "reais");


        }
    }
}
