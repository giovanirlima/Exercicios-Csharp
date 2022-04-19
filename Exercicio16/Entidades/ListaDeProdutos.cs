using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16.Entidades
{
    class ListaDeProdutos
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produtos { get; set; }

        public ListaDeProdutos()
        {
        }

        public ListaDeProdutos(int quantidade, double preco, Produto produtos)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produtos = produtos;
        }

        public double subTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return $"{Produtos.Nome}, R$ {Preco.ToString("F2")}, Quantidade {Quantidade}, SubTotal R$ {subTotal().ToString("F2")}";
        }


    }
}
