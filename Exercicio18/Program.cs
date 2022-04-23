using System;
using Exercicio17.Entidades;


List<Produto> lista = new List<Produto>();

Console.Write("Quantidade de produtos a venda: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Produto #{i + 1} é: ");

    Console.Write("Normal, usado ou importado (n/u/i): ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Preço: ");
    double preco = double.Parse(Console.ReadLine());

    if (resp == 'n')
    {
        lista.Add(new Produto(nome, preco));
    }

    else if (resp == 'u')
    {
        Console.Write("Data do lancamento (dia/mes/ano): ");
        DateTime data = DateTime.Parse(Console.ReadLine());

        lista.Add(new ProdutoUsado(nome, preco, data));
    }

    else
    {
        Console.Write("Preco de importação: ");
        double importacao = double.Parse(Console.ReadLine());

        lista.Add(new ProdutoImportado(nome, preco, importacao));

    }
}

Console.WriteLine();

Console.WriteLine("PREÇO DAS ETIQUETAS");

foreach (Produto produto in lista)
{
    Console.WriteLine(produto);
}