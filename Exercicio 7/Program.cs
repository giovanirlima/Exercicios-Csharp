using System;

namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'S' || resp == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(("Conta {0}, Titular: {1}, Saldo R$ {2}"), conta.Conta, conta.Cliente, conta.Saldo.ToString("F2"));

            Console.WriteLine();

            Console.Write("Entre com um valor de depósito: ");
            double dep = double.Parse(Console.ReadLine());
            conta.Deposito(dep);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(("Conta {0}, Titular: {1}, Saldo R$ {2}"), conta.Conta, conta.Cliente, conta.Saldo.ToString("F2"));

            Console.Write("Entre com um valor de saque: ");
            dep = double.Parse(Console.ReadLine());
            conta.Saque(dep);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(("Conta {0}, Titular: {1}, Saldo R$ {2}"), conta.Conta, conta.Cliente, conta.Saldo.ToString("F2"));
        }
    }
}