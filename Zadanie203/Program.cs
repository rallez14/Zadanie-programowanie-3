// Zadanie 3
int n, k;
decimal m;

long Silnia(int n)
{
    return n == 0 ? 1 : n * Silnia(n - 1);
}
start:
Console.WriteLine("Obliacznie liczby m=(n!-k!)/k! gdzie n i k to liczby naturalne nie mniejsze od 5");

try
{
    Console.Write("Podaj n: ");
    n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Podaj k: ");
    k = Convert.ToInt32(Console.ReadLine());

    if (n < 5 || k < 5)
    {
        Console.WriteLine("Liczby n i k muszą być naturalne oraz nie mniejsze niż 5");
        Thread.Sleep(2000);
        Console.Clear();
        goto start;
    }
    else
    {
        m = (decimal)(Silnia(n) - Silnia(k)) / Silnia(k);
        Console.WriteLine("m = " + m);
    }

}
catch (Exception)
{
    Console.WriteLine("Liczby n i k muszą być naturalne oraz nie mniejsze niż 5");
    Thread.Sleep(2000);
    Console.Clear();
    goto start;
}

