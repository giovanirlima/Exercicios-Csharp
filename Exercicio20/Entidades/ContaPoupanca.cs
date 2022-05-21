using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entidades
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }
        
        public ContaPoupanca()
        {
        }
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo = Saldo + (Saldo * TaxaJuros);
        }

        /*public override void Saque(double retirada)
        {
            Saldo -= retirada;
        }
        */

        public override void Saque(double retirada)
        {
            base.Saque(retirada);
            Saldo -= 2.0;
        }
    }
}
