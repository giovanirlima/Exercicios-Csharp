using System;
using System.Collections.Generic;
using System.Text;
using Exercicio.Entidades;

List<Funcionario> lista = new List<Funcionario>();

Console.Write("Entre como o numero de Funcionarios: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Funcionario #{i + 1} dados");
    Console.Write("Tercerizado (s/n)?: ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Horas: ");
    int horas = int.Parse(Console.ReadLine());

    Console.Write("Valor pago por hora: ");
    double vlPagoPorHora = double.Parse(Console.ReadLine());

    if (resp == 's')
    {
        Console.Write("Pagamento Adicional: ");
        double adicional = double.Parse(Console.ReadLine());

        lista.Add(new Tercerizado(nome, horas, vlPagoPorHora, adicional));
    }

    else
    {
        lista.Add(new Funcionario(nome, horas, vlPagoPorHora));
    }

}

Console.WriteLine();

Console.WriteLine("Pagamentos: ");

foreach (Funcionario funcionario in lista)
{
    Console.WriteLine($"{funcionario.Nome} - R$ {funcionario.Pagamento().ToString("F2")}");
}