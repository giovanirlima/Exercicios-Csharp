using System;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(p);

            /*
            Console.WriteLine(("Dados do produto: {0}, R$ {1}, {2} unidades, Total: R$ {3}"), p.Nome, p.Preco.ToString("F2"), p.Quantidade, p.ValorTotalEmEstoque());
            Console.WriteLine();

            Console.Write("Digite o numero a ser adicionado em estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine();
            Console.WriteLine(("Dados atualizados: {0}, R$ {1}, {2} unidades, Total: R$ {3}"), p.Nome, p.Preco.ToString("F2"), p.Quantidade, p.ValorTotalEmEstoque());

            Console.WriteLine();
            Console.Write("Digite o numero a ser removido em estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();
            Console.WriteLine(("Dados atualizados: {0}, R$ {1}, {2} unidades, Total: R$ {3}"), p.Nome, p.Preco.ToString("F2"), p.Quantidade, p.ValorTotalEmEstoque());


            */
        }

    }
}