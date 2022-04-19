using System;
using System.Collections.Generic;
using System.Text;
using Exercicio16.Entidades;
using Exercicio16.Entidades.Enums;

namespace Exercicio16.Entidades
{
    class Pedido
    {
        public DateTime Momento = DateTime.Now;
        public StatusDoPedido Status { get; set; }
        public Cliente Client { get; set; }
        public List<ListaDeProdutos> Lista { get; set; } = new List<ListaDeProdutos>();



        public Pedido(DateTime momento, StatusDoPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Client = cliente;
        }

        public void AddItem(ListaDeProdutos produto)
        {
            Lista.Add(produto);
        }
        public void RemoverItem(ListaDeProdutos produto)
        {
            Lista.Remove(produto);
        }

        public double Total()
        {
            double soma = 0.0;

            foreach (ListaDeProdutos lista in Lista)
            {
                soma += (Double)lista.subTotal();
            }

            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Momento da compra: {Momento.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Status da compra: {Status}");
            sb.AppendLine($"Cliente: {Client}");
            sb.AppendLine("Lista de itens:");
            foreach (ListaDeProdutos lista in Lista)
            {
                sb.AppendLine(lista.ToString());
            }
            sb.AppendLine($"Total: R$ {Total().ToString("F2")}");
            return sb.ToString();

        }
    }
}
