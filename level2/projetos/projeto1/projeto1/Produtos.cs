using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace projeto1
{
    class Produtos
    {
        public string Nome;
        public double preco;
        public int Quantidade;

        public double ValorEmEstoque()
        {
            return preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
