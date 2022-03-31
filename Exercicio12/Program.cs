
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] vet = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(vet[j]);

    }
}

Console.WriteLine("Diagonal Principal");

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{mat[i, i]} ");
}

Console.WriteLine();
int cont = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0)
        {
            cont++;
        }
    }
}
Console.WriteLine("Numeros negativos");
Console.WriteLine(cont);
