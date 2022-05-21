using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entidades
{
    class ContaEmpresarial : Conta
    {
        public double EmprestimoLimite { get; set; }

        public ContaEmpresarial()
        {
        }
        public ContaEmpresarial(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double emprestimo)
        {
            if (emprestimo <= EmprestimoLimite)
            {
                Saldo += emprestimo;

            } 
            else
            {
                Console.WriteLine("Limite não disponivel");
            }
        }




    }
}
