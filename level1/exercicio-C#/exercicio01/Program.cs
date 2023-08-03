using System;
using System.Globalization;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1
            /*
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é $ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero {genero}");
            Console.WriteLine();
            Console.WriteLine("Medida com 8 casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariante culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            */

            //exercicio 2
            /*
            Console.WriteLine("Entre com o seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bh = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha):");
            string[] unia = Console.ReadLine().Split(' ');
            string Unome = unia[0];
            int idade = int.Parse(unia[1]);
            double altura = double.Parse(unia[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(bh);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(Unome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            // exercicio 1 - prova
            /*
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine(soma);
            */

            //exercicio 2 - prova
            /*
            double raio = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine(area.ToString("F4"));
            */

            //exercicio 3 - prova
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int dif = (a * b) - (c * d);

            Console.WriteLine(dif);
            */

            //exercicio 4 - prova
            /*
            int nFuncionario = int.Parse(Console.ReadLine());
            int hTrabalho = int.Parse(Console.ReadLine());
            double vHora = double.Parse(Console.ReadLine());

            double horaTrabalhada = hTrabalho * vHora;

            Console.WriteLine(nFuncionario);
            Console.WriteLine(horaTrabalhada.ToString("F2"));
            */

            //exercicio 5 - prova
            /*
            Console.WriteLine("Escreva na linha nessa ordem: codigo da peça, numero de peças, valor unitário");
            string[] p1 = Console.ReadLine().Split(" ");
            Console.WriteLine("Escreva na linha nessa ordem: codigo da peça, numero de peças, valor unitário");
            string[] p2 = Console.ReadLine().Split(" ");

            int cPeca1 = int.Parse(p1[0]);
            int nPeca1 = int.Parse(p1[1]);
            double valUni1 = double.Parse(p1[2]);
            int cPeca2 = int.Parse(p2[0]);
            int nPeca2 = int.Parse(p2[1]);
            double valUni2 = double.Parse(p2[2]);

            double precoTotal = (nPeca1 * valUni1) + (nPeca2 * valUni2);

            Console.WriteLine("Valor total: R$" + precoTotal.ToString("F2"));
            */

            //exercicio 6 - prova
            /*
            Console.WriteLine("Digite os valores de A, B e C (na ordem):");
            string[] triangulos = Console.ReadLine().Split(" ");

            double a = double.Parse(triangulos[0]);
            double b = double.Parse(triangulos[1]);
            double c = double.Parse(triangulos[2]);

            double areaTR = a * c / 2;
            double areaC = Math.Pow(c, 2) * Math.PI;
            double areaT = ((a + b) * c) / 2;
            double areaQ = b * b;
            double areaR = a * b;

            Console.WriteLine(areaTR.ToString("F3"));
            Console.WriteLine(areaC.ToString("F3"));
            Console.WriteLine(areaT.ToString("F3"));
            Console.WriteLine(areaQ.ToString("F3"));
            Console.WriteLine(areaR.ToString("F3"));
            */

            // else - if

            //exeercicio 1
            /*
            double n = double.Parse(Console.ReadLine());
            if(n < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Positivo");
            }
            */

            //exercicio 2
            /*
            int a = int.Parse(Console.ReadLine());

            if(a % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            */

            //exercicio 3
            /*
            string[] valores = Console.ReadLine().Split();
            int B = int.Parse(valores[0]);
            int C = int.Parse(valores[1]);

            if(B % C == 0 || C % B == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não São Multiplos");
            }
            */

            //Exercicio 4
            /*
            string[] HiF = Console.ReadLine().Split();
            int D = int.Parse(HiF[0]);
            int E = int.Parse(HiF[1]);

            int duracao = 0;

            if(D < E)
            {
                duracao = E - D;
            }
            else
            {
                duracao = 24 - D + E;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + "HORAS(S)");
            */

            //EXERCICIO 5

            /*
            string[] produto = Console.ReadLine().Split();
            int F = int.Parse(produto[0]);
            int G = int.Parse(produto[1]);

            double valor = 0;

            if(F == 1)
            {
                valor = G * 4;
            }else if(F == 2)
            {
                valor = G * 4.5;
            }
            else if(F == 3)
            {
                valor = G * 5;
            }
            else if(F == 4)
            {
                valor = G * 2;
            }
            else if(F == 5)
            {
                valor = G * 1.5;
            }
            Console.WriteLine("Total: R$ " + valor);
            */

            //Exercicio 6
            /*
            double H = double.Parse(Console.ReadLine());

            if(H >= 0 && H <= 25)
            {
                Console.WriteLine("Intervalo (0, 25)");
            }else if(H > 25 && H <= 50)
            {
                Console.WriteLine("Intervalo (25, 50)");
            }else if(H > 50 && H <= 75)
            {
                Console.WriteLine("Intervalo (50, 75)");
            }else if(H > 75 && H <= 100)
            {
                Console.WriteLine("Intervalo (75, 100)");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            */

            //Exercicio 7
            /*
            string[] eixos = Console.ReadLine().Split();
            double i = double.Parse(eixos[0], CultureInfo.InvariantCulture);
            double J = double.Parse(eixos[1], CultureInfo.InvariantCulture);

            if (i == 0.0 && J == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if(i == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(J == 0)
            {
                Console.WriteLine("EixoY");
            }
            else if(i > 0 && J > 0)
            {
                Console.WriteLine("Q1");
            }else if(i < 0 && J < 0)
            {
                Console.WriteLine("Q3");
            }else if(i < 0 && J > 0)
            {
                Console.WriteLine("Q2");
            }else if(i > 0 && J < 0)
            {
                Console.WriteLine("Q4");
            }
            */

            //Exercicio 8
            /*
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;
            if(salario <= 2000)
            {
                imposto = 0.0;
            }else if(salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
            }else if(salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if(imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            */

            //Estrutura while
            //exercicio 01
            /*
            Console.WriteLine("Digite a senha:");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("SenhaIcorreta!!!");
                Console.WriteLine("Digite a senha novamente:");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha Correta");
            */

            //exercicio 2
            /*
            Console.WriteLine("Digite os valores de X e Y: ");
            string[] xy = Console.ReadLine().Split();
            double x = double.Parse(xy[0]);
            double y = double.Parse(xy[1]);

            while(x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("Quadrante 1");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("Quadrante 3");
                }
                else if(x > 0 && y < 0)
                {
                    Console.WriteLine("Quadrante 4");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("Quadrante 2");
                }

                Console.WriteLine("Digite o valor de X e Y: ");
                xy = Console.ReadLine().Split();
                x = double.Parse(xy[0]);
                y = double.Parse(xy[1]);
            }
            */

            //exercicio 3
            /*
            Console.WriteLine("Digite o codigo do produto: ");
            int produto = int.Parse(Console.ReadLine());

            int a = 0;
            int g = 0;
            int d = 0;

            while (produto != 4)
            {
                if(produto == 1)
                {
                    a += 1;
                }
                else if(produto == 2)
                {
                    g += 1;
                }
                else if(produto == 3)
                {
                    d += 1;
                }
                else
                {
                    Console.WriteLine("Digite um codigo Valido!");
                }
                Console.WriteLine("Digite o codigo do produto: ");
                produto = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado \n Alcool: " + a + "\n Gasolina: " + g + "\n Diesel: " + d);
            */

            // for
            //exercicio

            /*
            Console.WriteLine("Digite um valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i <= valor; i++)
            {
                if(i % 2 !=  0)
                {
                    Console.WriteLine(i);
                }
                else {}
            }
            */

            //exercicio 2
            /*
            Console.Write("Digite quantas numeros são: ");
            int qtd = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor: ");
            double v = double.Parse(Console.ReadLine());

            int In = 0;
            int Out = 0;

            for (int i = 1; i <= qtd; i++)
            {
                if (v >= 10 && v <= 20)
                {
                    In += 1;
                }
                else
                {
                    Out += 1;
                }
                Console.Write("Digite o valor: ");
                v = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("In " + In + " Out" + Out);
            */

            //exercicio 3
            /*
            Console.WriteLine("Numero de vezes a rodar o numero?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0;i < n; i++)
            {
               string[] xyz = Console.ReadLine().Split();

                double x = double.Parse(xyz[0]);
                double y = double.Parse(xyz[1]);
                double z = double.Parse(xyz[2]);

                double media = ((x * 2) + (y * 3) + (z * 5)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
            */

            //exercicio 4
            /*
            Console.WriteLine("Quantas vezes vaio rodar o programa: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i++)
            {
                
                string[] numebers = Console.ReadLine().Split();
                double n1 = double.Parse(numebers[0]);
                double n2 = double.Parse(numebers[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão Impossivel!");
                }
                else
                {
                    double divi = n1 / n2;
                    Console.WriteLine(divi);
                }
            }
            */

            //exercicio 5
            /*
            Console.WriteLine("Numero a ser encontrado o fator: ");
            double n = double.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                double fat = 1;
                for (int i = 1; i <= n; i++)
                {
                    fat = (fat * i);
                }

                Console.WriteLine(fat);
            }
            */

            //exercicio 6
            /*
            Console.WriteLine("Descubrir o numero: ");
            double n = double.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if(n%i != 0){ }
                else
                {
                    Console.WriteLine(i);
                }
            }
            */

            //exercicio 7

            Console.WriteLine("Numero a ser calculado o quadrado e o cubo: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + Math.Pow(i, 2) +" "+Math.Pow(i, 3));
            }

        }
    }
}
