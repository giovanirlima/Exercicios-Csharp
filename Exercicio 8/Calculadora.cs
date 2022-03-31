using System;


namespace Exercicio_8
{
    public class Calculadora
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public Calculadora(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public double Adicao()
        {
            return Num1 + Num2;
        }

        public double Subtracao()
        {
            return Num1 - Num2;
        }

        public double Divisao()
        {
            return Num1 / Num2;
        }

        public double Multiplicao()
        {
            return Num1 * Num2;
        }




    }
}
