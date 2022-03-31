using Exercicio_9;
/*
Console.WriteLine("Entre com valor: ");
int num = int.Parse(Console.ReadLine());

double[] vet = new double[num];

for (int i = 0; i < num; i++)
{
    vet[i] = double.Parse(Console.ReadLine());
}

double soma = 0.0;
for (int i = 0; i < num; i++)
{
    soma += vet[i];
}

double media = soma / num;
Console.WriteLine(media.ToString("F2"));*/

int n = int.Parse(Console.ReadLine());

Produto[] vet = new Produto[n];


for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine());
    vet[i] = new Produto { Nome = name, Preco = price };
}

double soma = 0.0;

for (int i = 0; i < n; i++)
{
    soma += vet[i].Preco;
}

double media = soma / n;
Console.WriteLine(media.ToString("F2"));
