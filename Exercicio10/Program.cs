using Exercicio10;


Estudante[] est = new Estudante[10];
Console.Write("Quantos quartos serão alugados? ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Aluguel #{i}:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    est[quarto] = new Estudante(nome, email);
}
Console.WriteLine();
Console.WriteLine("Quartos ocupados:");
for (int i = 1; i < 10; i++)
{
    if (est[i] != null)
    {
        Console.WriteLine(i + ": " + est[i]);
    }
}

