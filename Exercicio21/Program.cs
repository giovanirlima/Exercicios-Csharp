using System;
using ConsoleApp3.Entidades.Enums;
using ConsoleApp3.Entidades;

List<Figura> lista = new List<Figura>();

Console.Write("Informe o numero de Figuras: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Figura {i + 1} dados: ");

    Console.Write("Retangulo ou Ciculo (r/c): ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Cor da figura (PRETO/AZUL/VERMELHO): ");
    Cor cor = Enum.Parse<Cor>(Console.ReadLine());

    if (resp == 'r' || resp == 'R')
    {
        Console.Write("Informe a Largura: ");
        double larg = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a Altura");
        double alt = double.Parse(Console.ReadLine());

        lista.Add(new Retangulo(cor, larg, alt));
    }

    else
    {
        Console.Write("Informe o Raio: ");
        double raio = double.Parse(Console.ReadLine());

        lista.Add(new Circulo(cor, raio));
    }

}

Console.WriteLine();
Console.WriteLine("AREAS DAS FIGURAS");

foreach(Figura f in lista)
{
    Console.WriteLine(f.Area().ToString("F2"));
}