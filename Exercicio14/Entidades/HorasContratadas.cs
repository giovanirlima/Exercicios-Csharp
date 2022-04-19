using System;


namespace Exercicio14.Entidades
{
    class HorasContratadas
    {
        public DateTime Data { get; set; }  
        public double ValorPorHora { get; set; }
        public int HorasTrabalhadas { get; set; }

        public HorasContratadas()
        {

        }

        public HorasContratadas(DateTime data, double valorPorHora, int horasTrabalhadas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public double ValorTotal()
        {
            return ValorPorHora * HorasTrabalhadas;
        }
    }
}
