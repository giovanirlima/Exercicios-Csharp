using System;

namespace Exercicio_3
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do produto: {Nome}, R$ {Preco.ToString("F2")}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque()}";

            //, p.Nome, p.Preco.ToString("F2"), p.Quantidade, p.ValorTotalEmEstoque();
        }

    }
}
