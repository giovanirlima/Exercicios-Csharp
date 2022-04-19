using System;


namespace Exercicio16.Entidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime nascimento)
        {
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
        }

        public override string ToString()
        {
            return $"{Nome}, ({Nascimento.ToString("dd/MM/yyyy")}), - {Email}";
        }
    }
}
