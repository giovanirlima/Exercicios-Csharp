using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Entidades
{
    class Fisica : Pessoa
    {
        public double GastoComSaude { get; set; }

        public Fisica()
        {
        }

        public Fisica(string nome, double rendaAnual, double gastoComSaude) : base(nome, rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000)
            {
                if (GastoComSaude != 0)
                {
                    double imp = GastoComSaude / 2.0;
                    double porc = 0.15;
                    double VlFinal = RendaAnual * porc - imp;
                    return VlFinal;
                }
                else
                {
                    double porc = 0.15;
                    double VlFinal = RendaAnual * porc;
                    return VlFinal;
                }
            }
            else
            {
                if (GastoComSaude != 0)
                {
                    double imp = GastoComSaude / 2.0;
                    double porc = 0.25;
                    double VlFinal = RendaAnual * porc - imp;
                    return VlFinal;
                }
                else
                {
                    double porc = 0.25;
                    double VlFinal = RendaAnual * porc;
                    return VlFinal;
                }
            }
        }





    }
}
