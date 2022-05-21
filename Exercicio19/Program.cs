using System;

try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    int resultado = n1 / n2;

    Console.WriteLine(resultado);
}

catch (DivideByZeroException)
{
    Console.WriteLine("Numero não divisivel por 0!");
}
catch (FormatException)
{
    Console.WriteLine("Erro de formato!");
}