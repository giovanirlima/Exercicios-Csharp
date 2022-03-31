using System;

namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc;
            Console.WriteLine("Deseja executar um calculo matemático (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            while (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("1. SOMA");
                Console.WriteLine("2. SUBTRAÇÃO");
                Console.WriteLine("3. DIVISÃO");
                Console.WriteLine("4. MULTIPLICAÇÃO");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Informe os números: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" + ");
                    double n2 = double.Parse(Console.ReadLine());

                    calc = new Calculadora(n1, n2);
                    calc.Adicao();
                    Console.WriteLine(("Resultado: {0}"), calc.Adicao().ToString("F1"));
                    Console.WriteLine();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Informe os números: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" - ");
                    double n2 = double.Parse(Console.ReadLine());

                    calc = new Calculadora(n1, n2);
                    calc.Subtracao();
                    Console.WriteLine(("Resultado: {0}"), calc.Subtracao().ToString("F1"));
                    Console.WriteLine();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Informe os números: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" / ");
                    double n2 = double.Parse(Console.ReadLine());

                    calc = new Calculadora(n1, n2);
                    calc.Divisao();
                    Console.WriteLine(("Resultado: {0}"), calc.Divisao().ToString("F1"));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Informe os números: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" x ");
                    double n2 = double.Parse(Console.ReadLine());

                    calc = new Calculadora(n1, n2);
                    calc.Multiplicao();
                    Console.WriteLine(("Resultado: {0}"), calc.Multiplicao().ToString("F1"));
                    Console.WriteLine();
                }

                Console.WriteLine("Deseja executar outro calculo matemático (s/n)? ");
                resp = char.Parse(Console.ReadLine());

            }

            Console.WriteLine("OBRIGADO!");

        }
    }
}