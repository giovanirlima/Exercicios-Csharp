using System;
using ConsoleApp4.Entidades;
using System.Collections.Generic;

Console.Write("informe o numero de pagamento dos impostos: ");
int n = int.Parse(Console.ReadLine());

List<Pessoa> lista = new List<Pessoa>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.Write($"Dados do #{i + 1} pagamento");

    Console.Write("Individuo ou Juridico (i/j)? ");
    char resp = char.Parse(Console.ReadLine());

    if (resp == 'i' || resp == 'I')
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Renda anual: ");
        double renda = double.Parse(Console.ReadLine());

        Console.Write("Gastos com saúde: ");
        double saude = double.Parse(Console.ReadLine());

        lista.Add(new Fisica(nome, renda, saude));
    }

    else
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Renda anual: ");
        double renda = double.Parse(Console.ReadLine());

        Console.Write("Numero de Funcionarios: ");
        int qtdfun = int.Parse(Console.ReadLine());

        lista.Add(new Juridico(nome, renda, qtdfun));
    }
}

Console.WriteLine();

Console.WriteLine("Totel de imposto arrecadado");
double soma = 0.0;

foreach(Pessoa p in lista)
{
    soma += p.Imposto();
    Console.WriteLine($"{p.Nome}: R$ {p.Imposto().ToString("F2")}");
}

Console.WriteLine();

Console.WriteLine($"Pagamento total: R$ {soma.ToString("F2")}");