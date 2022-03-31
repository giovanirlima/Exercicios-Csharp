using System.Collections.Generic;
using Exercicio12;

Console.Write("Quantos funcionarios serão registrados? ");
int n = int.Parse(Console.ReadLine());

List<Funcionario> list = new List<Funcionario>();

for (int i = 0; i < n; i++)
{

    Console.WriteLine($"Funcionario #{i + 1}: ");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    string name = Console.ReadLine();

    Console.Write("Salario: ");
    double salary = double.Parse(Console.ReadLine());

    list.Add(new Funcionario(id, name, salary));
    Console.WriteLine();

}

Console.Write("Qual id do funcionario que recebera aumento: ");
int idAum = int.Parse(Console.ReadLine());

Funcionario fun = list.Find(x => x.Id == idAum);
if (fun != null)
{
    Console.WriteLine("Quanto sera a porcentagem de aumento: ");
    double porc = double.Parse(Console.ReadLine());
    fun.Bonus(porc);
}
else
{
    Console.WriteLine("Funcionario não existe");
}


Console.WriteLine();
Console.WriteLine("Lista de empregados:");

foreach (Funcionario func in list)
{
    Console.WriteLine(func);
}