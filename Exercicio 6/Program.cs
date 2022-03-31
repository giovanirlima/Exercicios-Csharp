using System;

namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dolares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine());

            double result = ConversorDeMoeda.DolarParaReal(cotacao, quantia);

            Console.WriteLine(("Valor a ser pago em reais = {0}"), result.ToString("F2"));
        }
    }
}