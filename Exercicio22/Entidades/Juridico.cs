using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Entidades
{
    class Juridico : Pessoa
    {
        public int Nfuncionarios { get; set; }

        public Juridico()
        {
        }

        public Juridico(string nome, double rendaAnual, int nfuncionarios) : base(nome, rendaAnual)
        {
            Nfuncionarios = nfuncionarios;
        }

        public override double Imposto()
        {
            if(Nfuncionarios >= 10)
            {
                double VlFinal = 0.0;
                VlFinal = RendaAnual * 0.14;
                return VlFinal;
            }
            else
            {
                double VlFinal = 0.0;
                VlFinal = RendaAnual * 0.16;
                return VlFinal;

            }
        }






    }
}
