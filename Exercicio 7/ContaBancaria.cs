using System;

namespace Exercicio_7
{
    internal class ContaBancaria
    {
        public int Conta { get; set; }
        public string Cliente { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string cliente)
        {
            Conta = conta;
            Cliente = cliente;
        }

        public ContaBancaria(int conta, string cliente, double saldo) : this(conta, cliente)
        {
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            double taxa = 5.0;
            Saldo -= taxa;
            Saldo -= saque;
        }
    }
}