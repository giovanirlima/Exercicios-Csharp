using System;
using Exercicio14.Entidades.Enums;
using System.Collections.Generic;

namespace Exercicio14.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public TrabalhadorLevel Level { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HorasContratadas> Contratos { get; set; } = new List<HorasContratadas>();

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, TrabalhadorLevel level, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Level = level;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(HorasContratadas newContrato)
        {
            Contratos.Add(newContrato);
        }

        public void RemoverContrato(HorasContratadas endContrato)
        {
            Contratos.Remove(endContrato);
        }

        public double Renda(int ano, int mes)
        {
            double soma = SalarioBase;

            foreach(HorasContratadas contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes )
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }

    }
}
