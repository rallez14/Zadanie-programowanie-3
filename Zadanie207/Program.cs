// Zadanie 7
Console.Write("Podaj n: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= n / 2; i++)
{
    Console.WriteLine($"{i} + {n - i}");
}
