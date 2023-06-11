// Zadanie 6
int x, n;
Console.WriteLine("Sprawdzam czy liczba x jest silnią liczby n");

Console.Write("Podaj x: ");
x = Convert.ToInt32(Console.ReadLine());

Console.Write("Podaj n: ");
n = Convert.ToInt32(Console.ReadLine());

long Silnia(int n)
{
    return n == 0 ? 1 : n * Silnia(n - 1);
}
long y = Silnia(n);

if (x == y)
{
    Console.WriteLine("n = " + n);
}
else
{
    Console.WriteLine("Liczba x nie jest silnią liczby n");
}