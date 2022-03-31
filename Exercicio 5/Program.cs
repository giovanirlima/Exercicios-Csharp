using System;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine(("Circunferência {0}:"), circ.ToString("F2"));
            Console.WriteLine(("Volume {0}:"), vol.ToString("F2"));
            Console.WriteLine(("Valor de PI = {0}"), Pi.ToString("F2"));


        }

        static double Pi = 3.14;
        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double volume)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(volume, 3.0);
        }
    }
}