using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime Data { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime data) : base(nome, preco)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Nome} (Usado) R$ {Preco.ToString("F2")} (Data da compra: {Data.ToString("dd/MM/yyyy")})";
        }
    }
}
