using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entidades.Enums;

namespace ConsoleApp3.Entidades
{
    class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(Cor cor) : base(cor)
        {
            
        }

        public Retangulo(Cor cor, double width, double height) : base(cor)
        {
            Largura = width;
            Altura = height;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
