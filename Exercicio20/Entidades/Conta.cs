using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entidades
{
    abstract class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; private set; }
        public double Saldo { get; set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public virtual void Saque(double retirada)
        {
            Saldo -= retirada + 5.0;
        }





    }
}
