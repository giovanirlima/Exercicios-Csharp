using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entidades.Enums;

namespace ConsoleApp3.Entidades
{
    abstract class Figura
    {
        public Cor Collor { get; set; }

        public Figura()
        {
        }

        public Figura(Cor cor)
        {
            Collor = cor;
        }

        public abstract double Area();
    }
}
