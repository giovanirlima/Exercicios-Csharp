using System;
using ConsoleApp3.Entidades.Enums;
using ConsoleApp3.Entidades;

namespace ConsoleApp3.Entidades
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo()
        {
        }

        public Circulo(Cor cor, double raio) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
