using System;
using System.Globalization;

namespace projeto1
{
    class Program
    {   
        static void Main(string[] args)
        {
            Produtos P = new Produtos();

            Console.WriteLine("Entre os dados do Produto: ");
            Console.Write("Nome: ");
            P.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            P.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            P.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do pruduto: " + P);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            P.AdicionarProdutos(quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do pruduto: " + P);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser Removido do estoque:");
            quantidade = int.Parse(Console.ReadLine());
            P.RemoverProdutos(quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do pruduto: " + P);
        }
    }
}
