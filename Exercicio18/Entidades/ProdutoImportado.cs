using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17.Entidades
{
    class ProdutoImportado : Produto
    {
        public double Importacao { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double importacao) : base(nome, preco)
        {
            Importacao = importacao;
        }

        public double Taxa()
        {
            return Preco + Importacao;
        }

        public override string ToString()
        {
            return $"{Nome} R$ {Taxa().ToString("F2")} (Custo da importação {Importacao.ToString("F2")})";
        }




    }
}
