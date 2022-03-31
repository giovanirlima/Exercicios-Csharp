using System;

namespace Exercicio12
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Bonus(double porc)
        {
            Salario = Salario + (Salario * porc / 100.0);
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario}";
        }
    }
}
