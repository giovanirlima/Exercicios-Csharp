using System;
using System.Collections.Generic;
using Exercicio16.Entidades;
using Exercicio16.Entidades.Enums;
using System.Globalization;

Console.WriteLine("Informe os dados do cliente");

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Data de aniversario (DD/MM/YYYY): ");
DateTime dn = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Insira os dados do pedido");

Console.Write("Status do pedido: ");
StatusDoPedido status = Enum.Parse<StatusDoPedido>(Console.ReadLine());

Console.Write("Quantos items para este pedido: ");
int n = int.Parse(Console.ReadLine());

Cliente cliente = new Cliente(nome, email, dn);
Pedido pedido = new Pedido(DateTime.Now, status, cliente);

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"#{i+1} - Informe os dados do pedido");

    Console.Write("Nome do produto: ");
    string pname = Console.ReadLine();

    Console.Write("Preço do produto: ");
    double ppreco = double.Parse(Console.ReadLine());

    Produto produto = new Produto(pname, ppreco);

    Console.WriteLine("Quantidade da compra: ");
    int quant = int.Parse(Console.ReadLine());

    ListaDeProdutos lista = new ListaDeProdutos(quant, ppreco, produto);

    pedido.AddItem(lista);
}
Console.WriteLine();

Console.WriteLine("Dados do Pedido: ");
Console.WriteLine(pedido);
