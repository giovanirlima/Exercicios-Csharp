using System;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno alu = new Aluno();

            Console.Write("Nome do aluno: ");
            alu.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            alu.N1 = double.Parse(Console.ReadLine());
            alu.N2 = double.Parse(Console.ReadLine());
            alu.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine(("NOTA FINAL = {0}"), alu.NotaFinal());

            if (alu.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }

            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine(("FALTARAM {0} PONTOS"), alu.NotaRestante());
            }
        }
    }
}
