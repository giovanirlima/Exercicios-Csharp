using System;
using ConsoleApp1.Entidades;
using System.Collections.Generic;


/*
Conta acc = new Conta(1001, "Giovani", 0.0);

ContaEmpresarial eacc = new ContaEmpresarial(1002, "Giovani R", 0.0, 500.0);

// UPCASTING

Conta acc1 = new Conta(1003, "Gustavo", 0.0);
Conta acc2 = new ContaEmpresarial(1003, "Gustavo", 0.0, 200.0);
Conta acc3 = new ContaPoupanca(1003, "Pedro", 0.00, 0.01);

    //DOWNCAST

ContaEmpresarial acc4 = (ContaEmpresarial)acc2;
acc4.Emprestimo(100.0);

    //ContaEmpresarial acc5 = (ContaEmpresarial)acc3;

if(acc3 is ContaEmpresarial)
{
    ContaEmpresarial acc5 = (ContaEmpresarial)acc3;
    acc5 = acc3 as ContaEmpresarial;
    acc5.Emprestimo(100.0);
    Console.WriteLine("Emprestimo autorizado!");
}
if (acc3 is ContaPoupanca)
{
    ContaPoupanca acc5 = (ContaPoupanca)acc3;
    acc5 = acc3 as ContaPoupanca;
    acc5.AtualizarSaldo();
    Console.WriteLine("Saldo atualizado!");
}

*/

List<Conta> lista = new List<Conta>();

lista.Add(new ContaPoupanca(1001, "Alex", 500.0, 0.01));
lista.Add(new ContaEmpresarial(1002, "Maria", 500.0, 400.0));
lista.Add(new ContaPoupanca(1001, "Bob", 500.0, 0.01));
lista.Add(new ContaEmpresarial(1002, "Anna", 500.0, 500.0));

double soma = 0.0;
foreach(Conta acc in lista)
{
    soma += acc.Saldo;
}

Console.WriteLine(soma);

foreach(Conta acc in lista)
{
    acc.Saque(10.0);
}

foreach(Conta acc in lista)
{
    Console.WriteLine($"Saldo atualizado para conta: {acc.Numero} : {acc.Saldo.ToString("F2")}");
}




