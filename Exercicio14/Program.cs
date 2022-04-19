using Exercicio14.Entidades.Enums;
using Exercicio14.Entidades;
using System;
using System.Globalization;



Console.Write("Qual o nome do departamento: ");
string nomeDept = Console.ReadLine();

Console.WriteLine("Dados do trabalhador: ");
Console.Write("Nome: ");
string trabNome = Console.ReadLine();

Console.Write("Qual a experiencia: Junior / Pleno / Senior: ");
TrabalhadorLevel level = Enum.Parse<TrabalhadorLevel>(Console.ReadLine());

Console.Write("Salario base: ");
double bsalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Departamento dept = new Departamento(nomeDept);

Trabalhador trab = new Trabalhador(trabNome, level, bsalario, dept);

Console.Write("Quantos contratos serão contratados? ");
int cont = int.Parse(Console.ReadLine());

for (int i = 0; i < cont; i++)
{
    Console.WriteLine($"Entre com os dados do contrato #{i+1}");
    Console.Write("Data (DD/MM/YYYY): ");
    DateTime data = DateTime.Parse(Console.ReadLine());

    Console.Write("Valor pago por hora: ");
    double vlphora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Duração (Horas): ");
    int horas = int.Parse(Console.ReadLine());

    HorasContratadas contrato = new HorasContratadas(data, vlphora, horas);

    trab.AdicionarContrato(contrato);
}

Console.WriteLine();

Console.Write("Informe o mês e ano para calcular a renda ( MM/YYYY ): ");
string mesEano = Console.ReadLine();
int mes = int.Parse(mesEano.Substring(0, 2));
int ano = int.Parse(mesEano.Substring(3));


Console.WriteLine("Nome: {0}", trab.Nome);
Console.WriteLine("Departamento: {0}", trab.Departamento.Nome);
Console.WriteLine("Renda {0}: R$ {1}", mesEano, trab.Renda(ano, mes).ToString("F2"));