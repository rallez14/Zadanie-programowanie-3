// Zadanie 10
int x;
Console.Write("Podaj liczbę naturalną co najmniej 3 cyfrową: ");
x = Convert.ToInt32(Console.ReadLine());
if (x < 100)
{
    Console.WriteLine("Podana liczba ma mniej niż 3 cyfry bądź nie jest naturalna");
}
else
{
    Console.WriteLine("Cyfry tej liczby to:");

    while (x > 0)
    {
        int y = x % 10;
        Console.WriteLine(y);
        x /= 10;
    }
}