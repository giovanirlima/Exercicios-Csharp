using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entidades
{
    class Tercerizado : Funcionario
    {
        public double PagamentoAdicional { get; set; }

        public Tercerizado()
        {
        }

        public Tercerizado(string nome, int horas, double valorPorHora, double pagamentoAdicional) : base(nome, horas, valorPorHora)
        {
            PagamentoAdicional = pagamentoAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * PagamentoAdicional;
        }


    }
}
