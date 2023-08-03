using System;

namespace exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            /*
            exercicio1 p1, p2;

            p1 = new exercicio1();
            p2 = new exercicio1();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: "); 
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Maior idade é da :" + p1.nome);
            }
            else
            {
                Console.WriteLine("Maior idade é da :" + p2.nome);
            }
            */

            //Exercicio 2
            /*
            exercicio2 f1, f2;

            f1 = new exercicio2();
            f2 = new exercicio2();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.sal = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.sal = double.Parse(Console.ReadLine());

            double mediaSal = (f1.sal + f2.sal) / 2;

            Console.WriteLine("Salário Médio = " + mediaSal);
            */

            //Exercicio 3
            /*
            Exercicio3 Ret = new Exercicio3();

            Console.WriteLine("Entre a largura e altura do rêtangulo:");
            Ret.Largura = double.Parse(Console.ReadLine());
            Ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(Ret);
            */

            //Exercicio 4
            /*
            Exercicio4 Func = new Exercicio4();

            Console.Write("Nome: ");
            Func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            Func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            Func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + Func);

            Console.Write("Imposto: ");
            double Porcento = double.Parse(Console.ReadLine());
            Func.NovoSalario(Porcento);

            Console.WriteLine("Funcionário: " + Func);
            */

            //Exercicio 5 

            Exercicio5 aluno = new Exercicio5();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine());
            aluno.N2 = double.Parse(Console.ReadLine());
            aluno.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final = " + aluno.NotaFinal());

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine(aluno.NotaRestante());
            }
        }
    }
}
